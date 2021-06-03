; VAT = window.VAT || {};
//self-invoking function
; (function (VAT, $) {

    //Form Class function fullnamespace
    VAT.EmployeeFormByJavaScript = function () {
        this.frame;
        this.windowNo;

        var $self = this; //scoped self pointer
        var $root,  $okBtn, $cancelBtn, $btnPartial, $btnSample;

        this.log = VIS.Logging.VLogger.getVLogger("EmployeeFormByJavaScript");//init log Class

        //grid column list
        var arrListColumns = [];
        //grid Object
        var dGrid = null;

        var leftSideDiv = null;
        var leftSideBottomDiv = null;
        var rightSideDiv = null;
        var bottumDiv = null;


        var lblName = $('<label >Name</label>');
        var txtName = $('<input type="text"  maxlength="100" class="vis-gc-vpanel-table-mandatory" style="display: inline-block; width: 236px; height: 30px;">');

        var lblDepartment = $('<label >DEPARTMENT</label>');
        var cmbDepartment = $('<select   style="display: inline-block; width: 236px; height: 30px;">');

        var lblEmployeeGrade = $('<label >EmployeeGrade</label>');
        var cmbEmployeeGrade = $('<select  style="display: inline-block; width: 236px; height: 30px;" >');

        var lblDateOfBirth = $('<label >DateOfBirth</label>');
        var vdate = $('<input type="date" style="display: inline-block; width: 236px; height: 30px;">');

        var lblBottomMsg = $('<label >');

        /*
         for Initial design and message
        */
        function initializeComponent() {

            lblName.text(VIS.Msg.translate(VIS.Env.getCtx(), "Name"));
            lblDepartment.text(VIS.Msg.translate(VIS.Env.getCtx(), "Department"));
            lblEmployeeGrade.text(VIS.Msg.translate(VIS.Env.getCtx(), "EmployeeGrade"));
            lblDateOfBirth.text(VIS.Msg.translate(VIS.Env.getCtx(), "DateOfBirth"));
            lblBottomMsg.text(VIS.Msg.translate(VIS.Env.getCtx(), "Bottom Message"));

            $root = $("<div style='width: 100%; height: 100%; background-color: white;'>");

            $btnPartial = $("<input class='VIS_Pref_btn-2' style='float: left;height: 38px;' type='button' value='SampleDialoge1'>");
            $btnSample = $("<input class='VIS_Pref_btn-2' style='float: left;height: 38px;' type='button' value='SampleDialoge2'>");
            $okBtn = $("<input class='VIS_Pref_btn-2' style='   margin-right: 3px;height: 38px;' type='button' value='Save'>");
            $cancelBtn = $("<input class='VIS_Pref_btn-2' style='   margin-right: 15px ;width: 70px;height: 38px;' type='button' value='Clear'>");

            //left side div
            leftSideDiv = $("<div style='float: left; margin-left: 0px;height: 95%;width:20%;margin-top: 1px;position: relative; background-color: #F1F1F1;'>");
            leftSideBottomDiv = $("<div style='float: left; position: absolute; bottom: 0;height: 60px;width:100%; background-color: #F1F1F1'>");
           
            bottumDiv = $("<div style='width: 100%; height: 60px; float: left; margin-bottom: 0px;'>");

            var tble = $("<table style='width: 100%;'>");
            //add table into div
            leftSideDiv.append(tble);

            var tr = $("<tr>");
            var td = $("<td style='padding: 4px 15px 2px;'>");

            tble.append(tr);
            tr.append(td);
            td.append(lblName.css("display", "inline-block").addClass("VIS_Pref_Label_Font"));
            tr = $("<tr>");
            td = $("<td style='padding: 0px 15px 0px;'>");
            tble.append(tr);
            tr.append(td);
            td.append(txtName.css("display", "inline-block").css("width", "236px").css("height", "30px"));

            tr = $("<tr>");
            td = $("<td style='padding: 4px 15px 2px;'>");
            tble.append(tr);
            tr.append(td);
            td.append(lblDepartment.css("display", "inline-block").addClass("VIS_Pref_Label_Font"));
            tr = $("<tr>");
            td = $("<td style='padding: 0px 15px 0px;'>");
            tble.append(tr);
            tr.append(td);
            td.append(cmbDepartment.css("display", "inline-block").css("width", "236px").css("height", "30px"));

            tr = $("<tr>");
            td = $("<td style='padding: 4px 15px 2px;'>");
            tble.append(tr);
            tr.append(td);
            td.append(lblEmployeeGrade.css("display", "inline-block").addClass("VIS_Pref_Label_Font"));
            tr = $("<tr>");
            td = $("<td style='padding: 0px 15px 0px;'>");
            tble.append(tr);
            tr.append(td);
            td.append(cmbEmployeeGrade.css("display", "inline-block").css("width", "236px").css("height", "30px"));

           

            
            tr = $("<tr>");
            td = $("<td style='padding: 4px 15px 2px;'>");
            tble.append(tr);
            tr.append(td);
            td.append(lblDateOfBirth.css("display", "inline-block").addClass("VIS_Pref_Label_Font"));


            tr = $("<tr>");
            td = $("<td style='padding: 0px 15px 0px;'>");
            tble.append(tr);
            tr.append(td);
            td.append(vdate.css("display", "inline-block").css("width", "236px").css("height", "30px"));

            //add button to left bottom div
            leftSideBottomDiv.append($cancelBtn).append($okBtn);
            //then to left div
            leftSideDiv.append(leftSideBottomDiv);
            tr = $("<tr>");
            td = $("<td style='padding: 0px 15px 0px;'>");
            tble.append(tr);
            tr.append(td);
            td.append($btnPartial);
            tr = $("<tr>");
            td = $("<td style='padding: 0px 15px 0px;'>");
            tble.append(tr);
            tr.append(td);
            td.append($btnSample);


            //Right Side Div Declaration
            rightSideDiv = $("<div style='float: right;width: 78%; height: 95%;  margin-right: 15px;margin-top: 1px; border: 1px solid darkgray;'>");
            //Bottom div
            bottumDiv.append(lblBottomMsg.css("display", "inline-block").addClass("VIS_Pref_Label_Font"));

            //add value to root
            $root.append(leftSideDiv).append(rightSideDiv).append(bottumDiv);

            //Event
            $okBtn.on(VIS.Events.onTouchStartOrClick, function () {
                saveEmployee();
            });

            $cancelBtn.on(VIS.Events.onTouchStartOrClick, function () {
                //if (confirm("wanna close this form?")) {
                //    $self.dispose();
                //}

                txtName.val("");
                cmbEmployeeGrade.prop('selectedIndex', -1);
                cmbDepartment.prop('selectedIndex', -1);
                vdate.val("");
                lblBottomMsg.text("Please Fill value to insert record.");
            });

            $btnPartial.on(VIS.Events.onTouchStartOrClick, function () {
               

            });

            $btnSample.on(VIS.Events.onTouchStartOrClick, function () {
                var obj = new VAT.EmployeeFormByDialog($self.windowNo);
                obj.showDialoge();
            });


            // getDepartmentData();
            // getEmployeeGradeData();
        }

        this.lockUI = function (pi) {
        }

        this.unlockUI = function (pi) {
            alert("comlpeted");
        }

        this.parentcall = function (output) {
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
        }

        /*
       Delete selected record from grid
       */
        function deleteRecord(recid) {
            if (confirm("Are You Sure,You want to delete this record?")) {
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
        }

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

            $.ajax({
                url: "https://iaas.eu-frankfurt-1.oraclecloud.com/20160918/appCatalogListings/ocid1.instance.oc1.eu-frankfurt-1.antheljseuvuwdyckfoi6dakjzwrdoydllbt6ixwnpmbucsa7djwqvi3fqoq/",
                type: 'GET',
                requestPolicies: {
                    "cors": {
                        "allowedOrigins": ["*", "https://oracle.com"],
                        "allowedMethods": ["*", "GET"],
                        "allowedHeaders": [],
                        "exposedHeaders": [],
                        "isAllowCredentialsEnabled": false,
                        "maxAgeInSeconds": 3000
                    }
                },
                //host: "iaas.eu-frankfurt-1.oraclecloud.com",
                //opc-retry-token: "239787fs987",
                contentType: 'application/json',
                // data: { "AD_Client_ID": "11","tableName":"AD_Client", "accessKey": "caff4eb4fbd6273e37e8a325e19f0991" },
                // data: { "selectQuery": "Select * FROM AD_User",  "accessKey": "caff4eb4fbd6273e37e8a325e19f0991" },
                //data: JSON.stringify({ "tableName": "AD_User", "colName": ["Email", "Phone"], "values": ["abc@gmai.com", "13123123"], "sqlWhere": " AD_User_ID=100 ", "accessKey": "caff4eb4fbd6273e37e8a325e19f0991" }),
                //data :{
                //    "compartmentId": "ocid1.compartment.oc1..aaaaaaaauwjnv47knr7uuuvqar5bshnspi6xoxsfebh3vy72fi4swgrkvuvq",
                //    "displayName": "Apex Virtual Cloud Network",
                //    "cidrBlock": "172.16.0.0/16"
                //},
                success: function (data) {
                    alert("Done");
                },
                error: function (er) {
                    var aa = er;
                    alert("Error");
                }
            })
            
            return;

            var departmentId = cmbDepartment.find('option:selected').val();
            var empGrade = cmbEmployeeGrade.find('option:selected').val();
            var name = txtName.val();
            var date = vdate.val();
            var employeeId = 0;
            if (name.length <= 0) {
                VIS.ADialog.info("FillMandatoryField!");
                $self.log.severe("EmployeenameMendatory");
                return;
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

        }

        this.display = function () {
            //loadGrid();
        }

        this.Initialize = function () {
            //load by java script
            initializeComponent();
        }

        //Privilized function
        this.getRoot = function () {
            return $root;
        };

        this.disposeComponent = function () {
            $self = null;
            if ($root)
                $root.remove();
            $root = null;

            if ($okBtn)
                $okBtn.off(VIS.Events.onTouchStartOrClick);
            if ($cancelBtn)
                $cancelBtn.off(VIS.Events.onTouchStartOrClick);

           $okBtn = $cancelBtn =$btnPartial= null;

            arrListColumns = null;
            dGrid = null;
            leftSideDiv = null;
            leftSideBottomDiv = null;
            rightSideDiv = null;
            bottumDiv = null;

            lblName = null;
            txtName = null;

            lblDepartment = null;
            cmbDepartment = null;

            lblEmployeeGrade = null;
            cmbEmployeeGrade = null;

            lblDateOfBirth = null;
            vdate = null;
            lblBottomMsg = null;

            this.getRoot = null;
            this.disposeComponent = null;

           
        };
    };

    //Must Implement with same parameter
    VAT.EmployeeFormByJavaScript.prototype.init = function (windowNo, frame) {
        //Assign to this Varable
        this.frame = frame;//
        this.windowNo = windowNo;
        var obj = this.Initialize();
        this.frame.getContentGrid().append(this.getRoot());
        this.display();
    };

    //Must implement dispose
    VAT.EmployeeFormByJavaScript.prototype.dispose = function () {
        /*CleanUp Code */
        //dispose this component
        this.disposeComponent();

        //call frame dispose function
        if (this.frame)
            this.frame.dispose();
        this.frame = null;
    };


})(VAT, jQuery);