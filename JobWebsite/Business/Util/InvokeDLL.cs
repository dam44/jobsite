using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.Util
{
    public class InvokeDLL
    {
        public static T ExportType<T>(string as_path, string as_typeName)
        {
            try {
                var ls_pathToDll = @as_path;
                var lo_asm = Assembly.LoadFile(ls_pathToDll);
                var lo_type = lo_asm.GetType(as_typeName);
                var lo_obj = Activator.CreateInstance(lo_type);
                return (T)lo_obj;
            } catch (Exception e) {
                return default(T);
            }
        }
    }
}
