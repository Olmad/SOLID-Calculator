using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Calculator_SOLID;
namespace Calculator_SOLID
{
    class KeyFilter
    {
        public bool ActionIsActive = false;
        public bool EnterIsActive = false;

        public string EnterF()
        {return "";}

        internal bool Filtration(KeyEventArgs e)
        {
            if(e.Key == Key.Enter) { EnterIsActive = true; return true; }else
            if (e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.D1
                || e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.D2
                || e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.D3
                || e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.D4
                || e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.D5
                || e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.D6
                || e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.D7
                || e.Key == Key.D8
                || e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.D9
                || e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.D0) 
            { EnterIsActive = false; return true;  }
            else if (!ActionIsActive&&(
                (e.KeyboardDevice.Modifiers == ModifierKeys.Shift && e.Key == Key.OemPlus)
                || e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.OemMinus
                || e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.Divide
                || e.KeyboardDevice.Modifiers != ModifierKeys.Shift && e.Key == Key.Multiply))
            {
                EnterIsActive = false;
                ActionIsActive = true;
                return true;
            }
            else {EnterIsActive = false; return false; }
        }
    }
}
