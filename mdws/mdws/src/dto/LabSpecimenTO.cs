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
using System.Text;
using gov.va.medora.mdo;
using gov.va.medora.utils;

namespace gov.va.medora.mdws.dto
{
    public class LabSpecimenTO : AbstractTO
    {
        public string id;
        public string name;
        public string collectionDate;
        public string accessionNum;
        public string site;
        public TaggedText facility;

        public LabSpecimenTO() { }

        public LabSpecimenTO(LabSpecimen mdo)
        {
            this.id = mdo.Id;
            this.name = StringUtils.stripInvalidXmlCharacters(mdo.Name);
            this.collectionDate = mdo.CollectionDate;
            this.accessionNum = mdo.AccessionNumber;
            this.site = mdo.Site;
            if (mdo.Facility != null)
            {
                this.facility = new TaggedText(mdo.Facility.Name);
            }
        }
    }
}
