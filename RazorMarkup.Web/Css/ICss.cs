﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.Css
{
    public interface ICss : IHideObjectMethods
    {
        ICssProperties Properties();
    }
}
/*
 * TODOs:
 * named colours
 * 
 */