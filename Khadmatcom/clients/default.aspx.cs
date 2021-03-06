﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Khadmatcom.Data.Model;
using Khadmatcom.Services;
using Khadmatcom.Services.Model;
using ServiceStack.Text;

namespace Khadmatcom.clients
{
    public partial class _default: PageBase
    {
        private readonly ServiceRequests _serviceRequests;
       
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public _default()
        {
            _serviceRequests=new ServiceRequests();
        }
        public IQueryable<ServiceRequest> GetServiceRequests()
        {
            var item= _serviceRequests.GetMemberRequests(CurrentUser.Id).AsQueryable();
            
            return item;
        }
    }
}