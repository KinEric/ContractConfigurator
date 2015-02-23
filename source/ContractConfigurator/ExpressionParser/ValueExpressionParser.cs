﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using KSP;
using ContractConfigurator.Parameters;

namespace ContractConfigurator.ExpressionParser
{
    public class ValueExpressionParser<T> : ExpressionParser<T> where T : struct
    {
        public ValueExpressionParser()
            : base()
        {
        }
    }

    public class ComparableValueExpressionParser<T> : ValueExpressionParser<T> where T : struct, IComparable<T>
    {
        public ComparableValueExpressionParser()
            : base()
        {
        }

        protected override bool LT(T a, T b)
        {
            return a.CompareTo(b) < 0;
        }

        protected override bool LE(T a, T b)
        {
            return a.CompareTo(b) <= 0;
        }

        protected override bool EQ(T a, T b)
        {
            return a.CompareTo(b) == 0;
        }

        protected override bool NE(T a, T b)
        {
            return a.CompareTo(b) != 0;
        }

        protected override bool GE(T a, T b)
        {
            return a.CompareTo(b) >= 0;
        }

        protected override bool GT(T a, T b)
        {
            return a.CompareTo(b) > 0;
        }
    }
}
