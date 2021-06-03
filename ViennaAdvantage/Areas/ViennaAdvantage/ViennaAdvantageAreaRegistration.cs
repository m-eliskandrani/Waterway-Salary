using System.Web.Mvc;
using System.Web.Optimization;



//NOTE:--    Please replace ViennaAdvantage with prefix of your module..



namespace ViennaAdvantage //  Please replace namespace with prefix of your module..
{
    public class ViennaAdvantageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ViennaAdvantage";   //Please replace "ViennaAdvantage" with prefix of your module.......
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ViennaAdvantage_default",
                "ViennaAdvantage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
                , new[] { "ViennaAdvantage.Controllers" }
            );    // Please replace ViennaAdvantage with prefix of your module...


            StyleBundle style = new StyleBundle("~/Areas/ViennaAdvantage/Contents/ViennaAdvantageStyle");

            /* ==>  Here include all css files in style bundle......see example below....  */

            style.Include("~/Areas/ViennaAdvantage/Contents/ViennaAdvantage.css");
            //              "~/Areas/ViennaAdvantage/Contents/example2.css");





            ScriptBundle script = new ScriptBundle("~/Areas/ViennaAdvantage/Scripts/ViennaAdvantageJs");

            /*-------------------------------------------------------
                    Here include all js files in style bundle......see example below....
             --------------------------------------------------------*/


            //script.Include("~/Areas/ViennaAdvantage/Scripts/model/callouts.js");


            /*-------------------------------------------------------
              Please replace "ViennaAdvantage" with prefix of your module..
             * 
             * 1. first parameter is script/style bundle...
             * 
             * 2. Second parameter is module prefix...
             * 
             * 3. Third parameter is order of loading... (dafault is 10 )
             * 
             --------------------------------------------------------*/
            //style.Include("~/Areas/ViennaAdvantage/Contents/ViennaAdvantage.all.min.css");
            //script.Include("~/Areas/ViennaAdvantage/Scripts/ViennaAdvantage.all.min.js");

            VAdvantage.ModuleBundles.RegisterScriptBundle(script, "ViennaAdvantage", 10);
            VAdvantage.ModuleBundles.RegisterStyleBundle(style, "ViennaAdvantage", 10);
        }
    }
}