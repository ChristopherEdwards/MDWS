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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using gov.va.medora.mdo.dao;
using gov.va.medora.mdo.dao.vista;

namespace gov.va.medora.mdo.api
{
    public class ToolsApi
    {
        public ToolsApi() { }

        public string[] ddrLister(
            AbstractConnection cxn,
            string file,
            string iens,
            string flds,
            string flags,
            string maxRex,
            string from,
            string part,
            string xref,
            string screen,
            string identifier)
        {
            VistaToolsDao dao = new VistaToolsDao(cxn);
            return dao.ddrLister(file, iens, flds, flags, maxRex, from, part, xref, screen, identifier);
        }

        public IndexedHashtable ddrLister(
            ConnectionSet cxns,
            string file,
            string iens,
            string flds,
            string flags,
            string maxRex,
            string from,
            string part,
            string xref,
            string screen,
            string identifier)
        {
            object[] args = new object[]
            {
                file,iens,flds,flags,maxRex,from,part,xref,screen,identifier
            };
            return cxns.query("IToolsDao", "ddrLister", args);
        }

        public string getVariableValue(AbstractConnection cxn, string arg)
        {
            VistaToolsDao dao = new VistaToolsDao(cxn);
            return dao.getVariableValue(arg);
        }

        public IndexedHashtable getVariableValue(ConnectionSet cxns, string arg)
        {
            return cxns.query("IToolsDao", "getVariableValue", new object[] { arg });
        }

        public IndexedHashtable getRpcList(ConnectionSet cxns, string target)
        {
            return cxns.query("IToolsDao", "getRpcList", new object[] { target });
        }

        public KeyValuePair<string, string>[] getRpcList(AbstractConnection cxn, string target)
        {
            VistaToolsDao dao = new VistaToolsDao(cxn);
            return dao.getRpcList(target);
        }

        public string getRpcName(AbstractConnection cxn, string rpcIEN)
        {
            VistaToolsDao dao = new VistaToolsDao(cxn);
            return dao.getRpcName(rpcIEN);
        }

        public IndexedHashtable isRpcAvailableAtSite(ConnectionSet cxns, string target, string localRemote, string version)
        {
            return cxns.query("IToolsDao", "isRpcAvailableAtSite", new object[] { target, localRemote, version });
        }

        public bool isRpcAvailableAtSite(AbstractConnection cxn, string target, string localRemote, string version)
        {
            VistaToolsDao dao = new VistaToolsDao(cxn);
            return dao.isRpcAvailableAtSite(target, localRemote, version);
        }

        public IndexedHashtable isRpcAvailable(ConnectionSet cxns, string target, string context)
        {
            return cxns.query("IToolsDao", "isRpcAvailable", new object[] { target, context });
        }

        public string isRpcAvailable(AbstractConnection cxn, string target, string context)
        {
            VistaToolsDao dao = new VistaToolsDao(cxn);
            return dao.isRpcAvailable(target, context);
        }

        public IndexedHashtable isRpcAvailable(ConnectionSet cxns, string target, string context, string localRemote, string version)
        {
            return cxns.query("IToolsDao", "isRpcAvailable", new object[] { target, context, localRemote, version });
        }

        public string isRpcAvailable(AbstractConnection cxn, string target, string context, string localRemote, string version)
        {
            VistaToolsDao dao = new VistaToolsDao(cxn);
            return dao.isRpcAvailable(target, context, localRemote, version);
        }

        public string[] ddrGetsEntry(AbstractConnection cxn, string file, string iens, string flds, string flags)
        {
            VistaToolsDao dao = new VistaToolsDao(cxn);
            return dao.ddrGetsEntry(file, iens, flds, flags);
        }

        public IndexedHashtable hasPatch(ConnectionSet cxns, string patchId)
        {
            return cxns.query("AbstractConnection", "hasPatch", new object[] { patchId });
        }

        //public bool hasPatch(AbstractConnection cxn, string patchId)
        //{

        //}

        public string runRpc(AbstractConnection cxn, string rpcName, string[] paramValues, int[] paramTypes, bool[] paramEncrypted)
        {
            VistaToolsDao dao = new VistaToolsDao(cxn);
            return dao.runRpc(rpcName, paramValues, paramTypes, paramEncrypted);
        }

        public IndexedHashtable runRpc(ConnectionSet cxns, string rpcName, string[] paramValues, int[] paramTypes, bool[] paramEncrypted)
        {
            return cxns.query("IToolsDao", "runRpc", new object[] { rpcName, paramValues, paramTypes, paramEncrypted });
        }
    }
}
