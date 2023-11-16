﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviES.Models.Content;

namespace MoviES.Interfaces
{
    public interface IContentManagement
    {

        public void AddContent(Content c) { }

        public void DeleteContent(Content c) { }

        public void ShowContent() { }

    }
}
