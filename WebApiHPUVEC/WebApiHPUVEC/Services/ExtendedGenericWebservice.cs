﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using WebApiHPUVEC.ArgoBasicService;

namespace WebApiHPUVEC.Services
{
    public class ExtendedGenericWebservice: ArgoService
    {

        private String _headerName;
        private String _headerValue;
        //
        protected override WebRequest GetWebRequest(Uri uri)
        {
            HttpWebRequest req = (HttpWebRequest)base.GetWebRequest(uri);
            if (null != _headerName)
            {
                req.Headers.Add(_headerName, _headerValue);
            }
            return (WebRequest)req;

        }
        //
        public void SetRequestHeader(String headerName, String headerValue)
        {

            this._headerName = headerName;
            this._headerValue = headerValue;
        }


    }
}