﻿using FluentAssertions;
using MainCore.Parsers.LoginPageParser;

namespace TestProject.Parsers.LoginPageParser
{
    [TestClass]
    public class TTWarsTest : ParserTestBase<TTWars>
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext _)
        {
            parts = Helper.GetParts<TravianOfficialTest>();
        }

        [TestMethod]
        public void GetUsernameNode_ShouldNotBeNull()
        {
            var (parser, html) = Setup("TTWars.html");

            var node = parser.GetUsernameNode(html);
            node.Should().NotBeNull();
        }

        [TestMethod]
        public void GetPasswordNode_ShouldNotBeNull()
        {
            var (parser, html) = Setup("TTWars.html");

            var node = parser.GetPasswordNode(html);
            node.Should().NotBeNull();
        }

        [TestMethod]
        public void GetLoginButton_ShouldNotBeNull()
        {
            var (parser, html) = Setup("TTWars.html");

            var node = parser.GetLoginButton(html);
            node.Should().NotBeNull();
        }
    }
}