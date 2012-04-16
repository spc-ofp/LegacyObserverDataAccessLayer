// -----------------------------------------------------------------------
// <copyright file="TrueFalseType.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using NHibernate;
    using NHibernate.SqlTypes;
    using NHibernate.UserTypes;

    /// <summary>
    /// I'm done messing with Query Substitutions that don't appear to work.
    /// http://lostechies.com/rayhouston/2008/03/23/mapping-strings-to-booleans-using-nhibernate-s-iusertype/
    /// </summary>
    public class TrueFalseType : IUserType
    {
        private static ISet<string> POSSIBLES = new HashSet<string>()
        {
            "t",
            "true",
            "f",
            "false"
        };
        
        public bool IsMutable
        {
            get { return false; }
        }

        public Type ReturnedType
        {
            get { return typeof(TrueFalseType); }
        }

        public SqlType[] SqlTypes
        {
            get { return new[] { NHibernateUtil.Boolean.SqlType }; }
        }

        public object NullSafeGet(IDataReader rs, string[] names, object owner)
        {
            var obj = NHibernateUtil.String.NullSafeGet(rs, names[0]);

            if (obj == null) return null;

            var trueFalse = ((string)obj).ToLower();
            System.Diagnostics.Debug.WriteLine("trueFalse is " + trueFalse);

            if (!POSSIBLES.Contains(trueFalse))
            {
                throw new Exception(String.Format("Couldn't parse value {0} as true or false", trueFalse));
            }
            bool isTrue = (trueFalse == "t" || trueFalse == "true");
            System.Diagnostics.Debug.WriteLine("isTrue: " + isTrue);
            return isTrue;
        }

        public void NullSafeSet(IDbCommand cmd, object value, int index)
        {
            if (value == null)
            {
                ((IDataParameter)cmd.Parameters[index]).Value = DBNull.Value;
            }
            else
            {
                var isTrue = (bool)value;
                ((IDataParameter)cmd.Parameters[index]).Value = isTrue ? "t" : "f";
            }
        }

        public object DeepCopy(object value)
        {
            return value;
        }

        public object Replace(object original, object target, object owner)
        {
            return original;
        }

        public object Assemble(object cached, object owner)
        {
            return cached;
        }

        public object Disassemble(object value)
        {
            return value;
        }

        public new bool Equals(object x, object y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (x == null || y == null) return false;

            return x.Equals(y);
        }

        public int GetHashCode(object x)
        {
            return x == null ? typeof(bool).GetHashCode() + 473 : x.GetHashCode();
        }
    }
}
