#region CopyrightHeader
//
//  Copyright by Contributors
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//         http://www.apache.org/licenses/LICENSE-2.0.txt
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
#endregion

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gov.va.medora.mdo.dao
{
    public class QueryThreadConnectionPool
    {
        Dictionary<string, IList<AbstractConnection>> _cxns;
        public EventHandler Changed;

        public virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
            {
                Changed(this, e);
            }
        }

        public void addConnection(string sitecode, AbstractConnection cxn)
        {
            lock (_cxns)
            {
                if (!_cxns.ContainsKey(sitecode))
                {
                    _cxns.Add(sitecode, new List<AbstractConnection>());
                }
                _cxns[sitecode].Add(cxn);
            }
        }
    }
}
