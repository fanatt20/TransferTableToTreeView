﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Task3.Tests
{
    [TestClass]
    public class TokenizerTest
    {
        [TestMethod]
        public void Tokenizer_SimpleExpr_Parsed()
        {
            var input = "+ 2 3";
            var str = new string[] {"+", "2", "3"};
            var tokenizer=new Tokenizer();
            var tokens = tokenizer.GetTokens(input);
            for (int i = 0; i < str.Length; i++)
            {
                Assert.AreEqual(str[i],tokens[i]);
            }
        }
        [TestMethod]
        public void Tokenizer_Complex_Parsed()
        {
            var input = "+ ( * 4 8 9 (/ 3 6) ) 3";
            var str = "+ ( * 4 8 9 (/ 3 6) ) 3".Split(' ');
            var tokenizer = new Tokenizer();
            var tokens = tokenizer.GetTokens(input);
            for (int i = 0; i < str.Length; i++)
            {
                Assert.AreEqual(str[i], tokens[i]);
            }
        }

    }
}