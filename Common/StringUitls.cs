using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class StringUitls
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int ToInt(object s)
        {
            try
            {
                int result;
                bool bl = int.TryParse(s.ToString(), out result);
                if (!bl)
                {
                    result = 0;
                }
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
    }
}
