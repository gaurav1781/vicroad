using System;
using System.Collections.Generic;
using System.Text;

namespace vicroad.feature
{
    class objectrepos
    {
        public static String URL = "https://www.vicroads.vic.gov.au/registration/limited-use-permits/unregistered-vehicle-permits/get-an-unregistered-vehicle-permit";
        public static  String vehicle_drpdwn="//*[@id=\"ph_pagebody_0_phthreecolumnmaincontent_0_panel_VehicleType_DDList\"]";
        public static  String psng_type="//*[@id=\"ph_pagebody_0_phthreecolumnmaincontent_0_panel_PassengerVehicleSubType_DDList\"]";
        public static  String goods_carrier_type="//*[@id=\"ph_pagebody_0_phthreecolumnmaincontent_0_panel_GoodsVehicleSubType_DDList\"]";
        public static  String address="//*[@id=\"ph_pagebody_0_phthreecolumnmaincontent_0_panel_AddressLine_SingleLine_CtrlHolderDivShown\"]";
        public static  String date="//*[@id=\"ph_pagebody_0_phthreecolumnmaincontent_0_panel_PermitStartDate_Date\"]";
        public static  String permit_duration="//*[@id=\"ph_pagebody_0_phthreecolumnmaincontent_0_panel_PermitDuration_DDList\"]";
        public static  String click_calc="//*[@id=\"ph_pagebody_0_phthreecolumnmaincontent_0_panel_btnCal\"]";
        public static  String submit="//input[@name=\'ph_pagebody_0$phthreecolumnmaincontent_0$panel$btnNext\']";
    }
}
