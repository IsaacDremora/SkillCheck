﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NUnit.Framework;
using Xunit;
//using NUnit.Framework.Legacy;

namespace SkillCheck.Tests.Junior
{
    public class ListTests
    {
        /*
         * Тест на объединение двух списков без дубликатов
         */

        [Fact]
        public void merge_two_lists_and_returns_unique_list()
        {
           var result = ListHelper.MergeLists(new List<int> { 1, 2, 3 }, new List<int> { 2, 3, 4 });
           Assert.Equal(new List<int> { 1, 2, 3, 4 }, result); // Ожидается список { 1, 2, 3, 4 }
        }
    }
}
