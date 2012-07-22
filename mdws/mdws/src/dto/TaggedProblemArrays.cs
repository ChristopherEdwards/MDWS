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
using gov.va.medora.mdo;

namespace gov.va.medora.mdws.dto
{
    public class TaggedProblemArrays : AbstractArrayTO
    {
        public TaggedProblemArray[] arrays;

        public TaggedProblemArrays() { }

        public TaggedProblemArrays(IndexedHashtable t)
        {
            if (t.Count == 0)
            {
                return;
            }
            arrays = new TaggedProblemArray[t.Count];
            for (int i = 0; i < t.Count; i++)
            {
                if (t.GetValue(i) == null)
                {
                    arrays[i] = new TaggedProblemArray((string)t.GetKey(i));
                }
                else if (MdwsUtils.isException(t.GetValue(i)))
                {
                    arrays[i] = new TaggedProblemArray((string)t.GetKey(i), (Exception)t.GetValue(i));
                }
                else if (t.GetValue(i).GetType().IsArray)
                {
                    arrays[i] = new TaggedProblemArray((string)t.GetKey(i), (Problem[])t.GetValue(i));
                }
                else
                {
                    arrays[i] = new TaggedProblemArray((string)t.GetKey(i), (Problem)t.GetValue(i));
                }
            }
            count = t.Count;
        }

        internal void add(string siteId, IList<Problem> problems)
        {
            if (arrays == null || arrays.Length == 0)
            {
                arrays = new TaggedProblemArray[1];
            }
            else
            {
                Array.Resize<TaggedProblemArray>(ref arrays, arrays.Length + 1);
            }

            arrays[arrays.Length - 1] = new TaggedProblemArray(siteId, ((List<Problem>)problems).ToArray());
        }
    }
}
