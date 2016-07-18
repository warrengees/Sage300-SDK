// The MIT License (MIT) 
// Copyright (c) 1994-2016 Sage Software, Inc.  All rights reserved.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of 
// this software and associated documentation files (the "Software"), to deal in 
// the Software without restriction, including without limitation the rights to use, 
// copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the 
// Software, and to permit persons to whom the Software is furnished to do so, 
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all 
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
// PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
// OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using ValuedParter.TU.Models;
using ValuedParter.Web.Areas.TU.Controllers;
using Microsoft.Practices.Unity;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Bootstrap;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Controller;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Repository;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Utilities;
using System.ComponentModel.Composition;
using System.Web.Mvc;

using Constants = ValuedParter.Web.Areas.TU.Constants;

namespace ValuedParter.Web
{
    /// <summary>
    /// TU Bootstrapper Class
    /// </summary>
    [Export(typeof(IBootstrapperTask))]
    [BootstrapMetadataExport("TU", new[] { BootstrapAppliesTo.Web }, 20)]
    public class TUWebBootstrapper : IBootstrapperTask
    {
        /// <summary>
        /// Bootstrap activity execution
        /// </summary>
        /// <param name="container">The Unity container</param>
        public void Execute(IUnityContainer container)
        {
            RegisterController(container);
            RegisterFinder(container);
            RegisterExportImportController(container);
        }

        /// <summary>
        /// Register controllers
        /// </summary>
        /// <param name="container">The Unity container</param>
        private void RegisterController(IUnityContainer container)
        {
            UnityUtil.RegisterType<IController, ReceiptController<ReceiptHeader, ReceiptDetail, ReceiptOptionalField, ReceiptDetailOptionalField, ReceiptDetailLotNumber, ReceiptDetailSerialNumber>>(container, "TUReceipt");
        }

        /// <summary>
        /// Register finders
        /// </summary>
        /// <param name="container">The Unity container</param>
        private void RegisterFinder(IUnityContainer container)
        {
        }

        /// <summary>
        /// Register import/export controllers
        /// </summary>
        /// <param name="container">The Unity container</param>
        private void RegisterExportImportController(IUnityContainer container)
        {
        }
    }
}
