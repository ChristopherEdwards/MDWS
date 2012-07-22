using System;
using System.Collections.Generic;
using System.Text;
using gov.va.medora;

namespace gov.va.medora.mdws.test
{
    /// <summary>
    /// A test object that can be set via Spring and fed to tests
    /// </summary>
    public class TestObject
    {
        private String siteCode;
        private String userName; // access code
        private String password; // e.g. VistA verify code
        private String context; // like CPRS context
        private String userDuz;
        private String patientDfn;

        /// <summary>
        /// 
        /// </summary>
        public String SiteCode
        {
            get {return siteCode;}
            set {siteCode = value;}
        }

        public String UserName
        {
            get {return userName;}
            set {userName = value;}
        }

        public String Password
        {
            get {return password;}
            set {password = value;}
        }

        public String Context
        {
            get {return context;}
            set {context = value;}
        }

        public String UserDuz
        {
            get {return userDuz;}
            set {userDuz = value;}
        }

        public String PatientDfn
        {
            get {return patientDfn;}
            set {patientDfn = value;}
        }
    }

    /// <summary>
    /// Very simple test object to wrap the generic dictionary class so that can
    /// more idiomatically set and get String properties...
    /// </summary>
    /// <remarks>
    /// * If the key/value hasn't been set, return null.
    /// * If trying to set a value for a key that has already been set, set over it.
    /// </remarks>
}
