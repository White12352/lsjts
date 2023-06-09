﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliLite.Api.Home
{
    public class HotAPI
    {
        public ApiModel Popular(string idx = "0",string last_param="")
        {
            ApiModel api = new ApiModel()
            {
                method = RestSharp.Method.Get,
                baseUrl = $"https://app.bilibili.com/x/v2/show/popular/index",
                parameter = ApiHelper.MustParameter(ApiHelper.AndroidKey, true) + $"&idx={idx}&last_param={last_param}"
            };
            api.parameter += ApiHelper.GetSign(api.parameter, ApiHelper.AndroidKey);
            return api;
        }

    }
}
