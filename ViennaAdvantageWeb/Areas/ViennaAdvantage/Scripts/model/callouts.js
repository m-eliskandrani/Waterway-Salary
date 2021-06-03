//1. Create All callout classes in this class so that user not need to add class in Registration Area Again and again.
//initialize your module prefix code
//Here MPC is VAT
; VAT = window.VAT || {};

; (function (VAT, $) {

    /**
    *  Callout Class
       -  must call this function
       -  VIS.CalloutEngine.call(this, [className]);
    */
    function CalloutEmployeeSalary() {
        VIS.CalloutEngine.call(this, "VAT.CalloutEmployeeSalary"); //must call
    };

    /**
     * Inherit CallourEngile Class 
    */
    VIS.Utility.inheritPrototype(CalloutEmployeeSalary, VIS.CalloutEngine);//inherit CalloutEngine

    //Callout Method defined as Function prototype
    CalloutEmployeeSalary.prototype.netSalary = function (ctx, windowNo, mTab, mField, value, oldValue) {
        if (this.isCalloutActive() || value == null || value.toString() == "") {
            return "";
        }

        this.setCalloutActive(true);

        try {

            var netsalary, gross, basic, hra, pf, tds;
            //	get values
            basic = VIS.Utility.Util.getValueOfDecimal(mTab.getValue("VAT_BasicSalary"));
            hra = VIS.Utility.Util.getValueOfDecimal(mTab.getValue("VAT_HRA"));
            tds = VIS.Utility.Util.getValueOfDecimal(mTab.getValue("VAT_TDS"));
            pf = VIS.Utility.Util.getValueOfDecimal(mTab.getValue("VAT_PF"));

            this.log.fine("BasicSalary=" + basic + ", hra=" + hra + ", pf=" + pf);

            netsalary = basic + hra - (pf + tds);
            //Gross Salary include all
            gross = basic + hra + pf + tds;

            // var isSOTrx = (ctx.getWindowContext(windowNo, "IsSOTrx", true) == "Y");

            mTab.setValue("VAT_NET", netsalary);
            mTab.setValue("VAT_Gross", gross);

        }
        catch (err) {
            VIS.ADialog.info("error in NetSalary" + err, null, "", "");
            this.setCalloutActive(false);
            return err;
        }
        this.setCalloutActive(false);
        ctx = windowNo = mTab = mField = value = oldValue = null;
        return "";
    };

    //initialise model object in VAT
    VAT.Model = VAT.Model || {};
    VAT.Model.CalloutEmployeeSalary = CalloutEmployeeSalary; //assign object in Model NameSpace



    /***************************** Second Callout Class CalloutDepartment*****************************/
    /**
   *  Callout Class CalloutDepartment
      -  must call this function
      -  VIS.CalloutEngine.call(this, [className]);
   */
    function CalloutDepartment() {
        VIS.CalloutEngine.call(this, "VAT.CalloutDepartment"); //must call
    };
    /**
   * Inherit CallourEngile Class 
  */
    VIS.Utility.inheritPrototype(CalloutDepartment, VIS.CalloutEngine);//inherit CalloutEngine
    //Callout Method defined as Function prototype
    CalloutDepartment.prototype.showDepartmentCode = function (ctx, windowNo, mTab, mField, value, oldValue) {
        if (this.isCalloutActive() || value == null || value.toString() == "") {
            return "";
        }

        this.setCalloutActive(true);
        var self = this;
        try {
            var departmentid = value;

            $.ajax({
                url: VIS.Application.contextUrl + "VAT/Callout/GetDepartmentCode",
                data: { depID: departmentid },
                success: function (result) {
                    if (result) {
                        mTab.setValue("VAT_DepartmentCode", result);
                    }
                    self.setCalloutActive(false);
                    ctx = windowNo = mTab = mField = value = oldValue = null;
                },
                error: function (eror) {
                    self.setCalloutActive(false);
                    console.log(eror);
                    self.log.severe(eror.toString());
                    ctx = windowNo = mTab = mField = value = oldValue = null;

                }

            });
        }   //  re-read customer rules
        catch (err) {
            this.setCalloutActive(false);
            this.log.severe(err.toString());
        }
    };



    //initialise model object in VAT
    VAT.Model = VAT.Model || {};
    VAT.Model.CalloutDepartment = CalloutDepartment; //assign object in Model NameSpace



})(VAT, jQuery);