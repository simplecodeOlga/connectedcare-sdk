﻿#region Copyright
//    Copyright 2015 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
#endregion

namespace SnapMD.ConnectedCare.ApiModels.Payments 
{

    /// 
    /// <summary>
    /// These models are for deserializing the responses from the Authorize.net API.
    /// </summary>
    public class PaymentProfile {

        public CimAddress BillingAddress { get; set; }
        public string ProfileID { get; set; }
        public bool IsBusiness { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public string CardExpiration { get; set; }
        public string CardCode { get; set; }
    }

}