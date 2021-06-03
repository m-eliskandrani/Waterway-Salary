; VAT = window.VAT || {};

/*java script function closer */
; (function (VAT, $) {

    /*
    Main class used to open form as a dialog
    */
    function EmployeeFormByDialog(windownu) {

        /*main parent container div */
        var $root = $("<div>");
        var $busyDiv = $("<div class='vis-apanel-busy'>");
        var $self = this; //scoped self pointer

        var okBtn = null;
        var cancelBtn = null;

        //grid column list
        var arrListColumns = [];
        //grid Object
        var dGrid = null;

        var leftSideDiv = null;
        var leftSideBottomDiv = null;
        var rightSideDiv = null;


        var lblName = null;
        var txtName = null;

        var lblDepartment = null;
        var cmbDepartment = null;

        var lblEmployeeGrade = null;
        var cmbEmployeeGrade = null;

        var lblDateOfBirth = null;
        var vdate = null;

        var lblBottomMsg = null;
        var windowNo = Number(VIS.Env.getWindowNo());

        /*Function is responsible for loading view*/
        function load() {
            //call partial view
            $root.load(VIS.Application.contextUrl + 'VAT/EmployeeByView/Index/?windowno=' + windowNo, function (event) {
                //find objects from loaded root 
                lblName = $root.find("#lblName_" + windowNo);
                txtName = $root.find("#txtName_" + windowNo);

                lblDepartment = $root.find("#lblDepartment_" + windowNo);
                cmbDepartment = $root.find("#cmbDepartment_" + windowNo);

                lblEmployeeGrade = $root.find("#lblEmployeeGrade_" + windowNo);
                cmbEmployeeGrade = $root.find("#cmbEmployeeGrade_" + windowNo);

                lblDateOfBirth = $root.find("#lblDateOfBirth_" + windowNo);
                vdate = $root.find("#vdate_" + windowNo);

                lblBottomMsg = $root.find("#lblBottomMsg_" + windowNo);

                leftSideDiv = $root.find("#leftSideDiv_" + windowNo);
                leftSideBottomDiv = $root.find("#leftSideBottomDiv_" + windowNo);
                rightSideDiv = $root.find("#rightSideDiv_" + windowNo);



                okBtn = $root.find("#btnOk_" + windowNo);
                cancelBtn = $root.find("#btnCancel_" + windowNo);

                lblName.text(VIS.Msg.translate(VIS.Env.getCtx(), "Name"));
                lblDepartment.text(VIS.Msg.translate(VIS.Env.getCtx(), "Department"));
                lblEmployeeGrade.text(VIS.Msg.translate(VIS.Env.getCtx(), "EmployeeGrade"));
                lblDateOfBirth.text(VIS.Msg.translate(VIS.Env.getCtx(), "DateOfBirth"));
                lblBottomMsg.text(VIS.Msg.translate(VIS.Env.getCtx(), "Bottom Message"));


                //Event
                okBtn.on(VIS.Events.onTouchStartOrClick, function () {
                    saveEmployee();
                });

                cancelBtn.on(VIS.Events.onTouchStartOrClick, function () {
                    //if (confirm("wanna close this form?")) {
                    //    dispose();
                    //}

                    txtName.val("");
                    cmbEmployeeGrade.prop('selectedIndex', -1);
                    cmbDepartment.prop('selectedIndex', -1);
                    vdate.val("");
                    lblBottomMsg.text("Please Fill value to insert record.");
                });

                getDepartmentData();
                getEmployeeGradeData();
                loadGrid();

            });
        };

        /*
        Delete selected record from grid
        */
        function deleteRecord(recid) {
            VIS.ADialog.confirm("DeleteConfirm", true, "", "Confirm", function (result) {
                if (result) {
                    var employeeId = dGrid.get(recid).VAT_Employee_ID;

                    $.ajax({
                        type: "POST",
                        url: VIS.Application.contextUrl + "VAT/Common/Delete",
                        dataType: "json",
                        data: {
                            'employeeId': employeeId
                        },
                        success: function (data) {
                            var returnValue = data.result;
                            if (returnValue) {

                                lblBottomMsg.text("Record Deleted.");
                                loadGrid();
                                //$self.dispose();
                                return;
                            }
                            lblBottomMsg.text("Record not delete.");
                        }
                    });
                }
            });
        };

        /*
        get department to load combo
        */

        function getDepartmentData() {
            cmbDepartment.empty();
            $.ajax({
                url: VIS.Application.contextUrl + "VAT/Common/GetDepartmentData",
                success: function (result) {
                    result = JSON.parse(result);
                    if (result && result.length > 0) {
                        for (var i = 0; i < result.length; i++) {
                            cmbDepartment.append(" <option value=" + result[i].ID + ">" + result[i].Value + "</option>");
                        }
                        cmbDepartment.prop('selectedIndex', 0);
                    }
                },
                error: function (eror) {
                    console.log(eror);
                }

            });
        };

        /*
        get all grade and fill combo
        */
        function getEmployeeGradeData() {
            cmbEmployeeGrade.empty();
            $.ajax({
                url: VIS.Application.contextUrl + "VAT/Common/GetEmployeeGrade",
                success: function (result) {
                    result = JSON.parse(result);
                    if (result && result.length > 0) {
                        for (var i = 0; i < result.length; i++) {
                            cmbEmployeeGrade.append(" <option value=" + result[i].ID + ">" + result[i].Value + "</option>");
                        }
                        cmbEmployeeGrade.prop('selectedIndex', 0);
                    }
                },
                error: function (eror) {
                    console.log(eror);
                }
            });
        };

        /*
        save employee 
        */
        function saveEmployee() {
            var departmentId = cmbDepartment.find('option:selected').val();
            var empGrade = cmbEmployeeGrade.find('option:selected').val();
            var name = txtName.val();
            var date = vdate.val();
            var employeeId = 0;
            if (name.length <= 0) {
                VIS.ADialog.info("FillMandatoryField!")
            }
            if (date != "") {
                date = date.toString();
            }

            $.ajax({
                type: "POST",
                url: VIS.Application.contextUrl + "VAT/Common/Save",
                dataType: "json",
                data: {
                    'employeeId': employeeId,
                    'name': name,
                    'departmentId': departmentId,
                    'empGrade': empGrade,
                    'date': date
                },
                success: function (data) {
                    var returnValue = data.result;
                    if (returnValue) {

                        lblBottomMsg.text("Record saved.");
                        loadGrid();
                        //$self.dispose();
                        return;
                    }
                    lblBottomMsg.text("Record not saved.");
                }
            });

        };

        /*
        Get data and fill grid selected record from grid
        */
        function loadGrid() {
            var data = [];

            var AD_Client_ID = VIS.Env.getCtx().getAD_Client_ID();

            $.ajax({
                url: VIS.Application.contextUrl + "VAT/Common/LoadEmployeeData",
                data: { AD_Client_ID: AD_Client_ID },
                async: false,
                success: function (result) {
                    result = JSON.parse(result);
                    if (result && result.length > 0) {
                        for (var i = 0; i < result.length; i++) {
                            var line = {};
                            line['VAT_Employee_ID'] = result[i].EmpID;
                            line['Name'] = result[i].Name;
                            line['vat_departmentname'] = result[i].DepName;
                            line['VAT_EmployeeGrade'] = result[i].Grade;
                            line['V_Date'] = result[i].Date;
                            line['VAT_Department_ID'] = result[i].DepID;
                            line['recid'] = i + 1;
                            data.push(line);
                        }
                    }
                    dynInit(data);
                },
                error: function (eror) {
                    console.log(eror);
                }
            });
            return data;
        };

        /*
        function where grid column and grid handling/loading
        */
        function dynInit(data) {

            if (dGrid != null) {
                dGrid.destroy();
                dGrid = null;
            }

            if (arrListColumns.length == 0) {
                arrListColumns.push({ field: "Name", caption: VIS.Msg.translate(VIS.Env.getCtx(), "Name"), sortable: true, size: '20%', min: 150, hidden: false });
                arrListColumns.push({ field: "vat_departmentname", caption: VIS.Msg.translate(VIS.Env.getCtx(), "Department"), sortable: true, size: '20%', min: 150, hidden: false });
                arrListColumns.push({ field: "VAT_EmployeeGrade", caption: VIS.Msg.translate(VIS.Env.getCtx(), "EmployeeGrade"), sortable: true, size: '20%', min: 150, hidden: false });
                arrListColumns.push({ field: "V_Date", caption: VIS.Msg.translate(VIS.Env.getCtx(), "DateOfBirth"), sortable: true, size: '20%', min: 150, hidden: false, render: 'date' });

                arrListColumns.push({
                    field: "Delete", caption: VIS.Msg.translate(VIS.Env.getCtx(), "Delete"), sortable: true, size: '80px', min: 150, hidden: false,
                    render: function () { return '<div><img src="' + VIS.Application.contextUrl + 'Areas/VIS/Images/base/Delete24.png" alt="Delete record" title="Delete record" style="opacity: 1;"></div>'; }
                });


                arrListColumns.push({ field: "VAT_Employee_ID", caption: VIS.Msg.getElement(VIS.Env.getCtx(), "VAT_Employee_ID"), sortable: true, size: '150px', hidden: true });
                arrListColumns.push({ field: "VAT_Department_ID", caption: VIS.Msg.getElement(VIS.Env.getCtx(), "VAT_Department_ID"), sortable: true, size: '20%', min: 150, hidden: true });
            }

            setTimeout(10);

            //encode data
            w2utils.encodeTags(data);

            dGrid = $(rightSideDiv).w2grid({
                name: "gridGenEmployeeForm" + $self.windowNo,
                recordHeight: 40,
                // show: { selectColumn: true },
                // multiSelect: true,
                columns: arrListColumns,
                records: data,
                onClick: function (event) {
                    if (event.column == 4 && dGrid.records.length > 0) {
                        deleteRecord(event.recid);
                    }
                }
            });
        };


        ///show via jquery dialog method

        this.showDialoge = function () {
            load();
            $busyDiv.height(400);
            $root.append($busyDiv);
            $root.dialog({
                modal: true,
                title: VIS.Msg.getMsg("Dialog"),
                height: $(window).height() - 100,
                width: $(window).width() - 100,
                position: { at: "center top", of: window },
                close: function () {
                    $self.dispose();
                    $root.dialog("destroy");
                    $root = null;
                }
            });
        };

        /* Show form provided By Framework Method */

        this.show = function () {
            load();
            var $root = $("<div><p>Sample Dialoge</p></div>");
            $busyDiv.height(400); //show busy symbol

            var ch = new VIS.ChildDialog(); //create object of child dialog
            ch.setHeight($(window).height() - 100);
            ch.setWidth($(window).width() - 100);
            ch.setTitle(VIS.Msg.getMsg("DemoForm"));
            ch.setModal(true); //set form dialog modal property
            ch.setContent($root); //set the content

            //Disposing Everything on Close
            ch.onClose = function () {

                if ($self.onClose) $self.onClose();
                $self.dispose();
            };
            ch.show();


            //Ok Button Click
            ch.onOkClick = function (e) {
                VIS.ADialog.info("OKClicked"); //
            };


            //Cancel Button Click
            ch.onCancelClick = function () {
                VIS.ADialog.info("CancelClicked");
            };

        };



        /*
        dispose all object used in this form
        */
        this.disposeComponent = function () {
            if (okBtn)
                okBtn.off("click");
            if (cancelBtn)
                cancelBtn.off("click");
            $busyDiv = null;
            okBtn = null;
            cancelBtn = null;
            arrListColumns = null;
            dGrid = null;
            leftSideDiv = null;
            leftSideBottomDiv = null;
            rightSideDiv = null;
            lblName = null;
            txtName = null;
            lblDepartment = null;
            cmbDepartment = null;
            lblEmployeeGrade = null;
            cmbEmployeeGrade = null;
            lblDateOfBirth = null;
            vdate = null;
            lblBottomMsg = null;
            windowNo = null;
            this.disposeComponent = null;
        };
    }

    EmployeeFormByDialog.prototype.dispose = function () {
        this.disposeComponent();
    };

    //Load form into VIS
    VAT.EmployeeFormByDialog = EmployeeFormByDialog;

})(VAT, jQuery);