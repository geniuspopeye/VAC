﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Module
{
    class Z : Math_Field
    {
        #region Конструкторы

        public Z(List<string> s)
        {

        }

        public Z(N value)
        {

        }

        #endregion

        #region Поля

        private N Abs;
        private bool isN;

        #endregion

        #region Свойства

        protected override bool isDown
        {
            get
            {
                return Convert.ToBoolean(new Exception());
            }
        }

        public N ABS_Z_N
        {
            get
            {
                return null;
            }
        }

        public byte POZ_Z_D
        {
            get
            {
                return 0;
            }
        }

        #endregion

        #region Перегрузки

        public static Z operator -(Z value) // MUL_ZM_Z
        {
            return null;
        }

        public static Z operator +(Z first, Z second) // ADD_ZZ_Z
        {
            return null;
        }

        public static Z operator -(Z first, Z second) // SUB_ZZ_Z
        {
            return null;
        }

        public static Z operator *(Z first, Z second) // MUL_ZZ_Z
        {
            return null;
        }

        public static Z operator /(Z first, Z second) // DIV_ZZ_Z
        {
            return null;
        }

        public static Z operator %(Z first, Z second) // MOD_ZZ_Z
        {
            return null;
        }

        public static implicit operator List<string>(Z value)
        {
            return null;
        }

        public static implicit operator Q(Z value)
        {
            return null;
        }

        public static explicit operator N(Z value)
        {
            return null;
        }

        #endregion
    }
}
