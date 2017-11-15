﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASRuntime.nativefuncs
{
    class Catch
    {
        public static bool isCatchError(int tryid,ASBinCode.RunTimeValueBase throwValue,ASBinCode.OpStep step,ASBinCode.RunTimeScope scope,StackFrame frame)
        {
            int id = ((ASBinCode.rtData.rtInt)((ASBinCode.rtData.RightValue)step.arg1).getValue(null,null,0)).value;
            if (tryid == id)
            {
                return TypeConverter.testTypeMatch(throwValue, step.regType,frame.player.swc);
            }
            return false;
        }
    }
}
