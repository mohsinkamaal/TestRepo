using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcfsba
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "supliermanager" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select supliermanager.svc or supliermanager.svc.cs at the Solution Explorer and start debugging.
    public class supliermanager : Isupliermanager
    {
        public void add(SUPPLIER obj)
        {
            var objcontext = new PODb1Entities();
            objcontext.SUPPLIERs.Add(obj);
            objcontext.SaveChanges();
        }

        public void delete(int id)
        {
            var objcontext = new PODb1Entities();
            var data = objcontext.SUPPLIERs.Find(id);
            objcontext.SUPPLIERs.Remove(data);
            objcontext.SaveChanges();
        }

        public SUPPLIER[] GetSUPPLIERs()
        {
            var obj = new PODb1Entities();
            var data = obj.SUPPLIERs.ToArray();
            return data;
        }

        public SUPPLIER GetUPPLIER(int supno)
        {
            var obj = new PODb1Entities();
            var data = obj.SUPPLIERs.Find(supno);
            return data;
        }

        public void update(SUPPLIER obj)
        {
            var objcontext = new PODb1Entities();
            objcontext.SUPPLIERs.Attach(obj);
            objcontext.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            objcontext.SaveChanges();
        }
    }
}
