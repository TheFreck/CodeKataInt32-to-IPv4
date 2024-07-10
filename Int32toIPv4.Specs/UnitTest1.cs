using Machine.Specifications;

namespace Int32toIPv4.Specs
{
    public class When_Parsing_A_32_Bit_Binary
    {
        Establish context = () =>
        {
            input = 2149583361;
            expect = "10000000.00100000.00001010.00000001";
        };

        Because of = () => answer = IPconverter.GetBinary(input);

        It Should_Parse_Int_Into_Binary_String = () => answer.ShouldEqual(expect);

        private static uint input;
        private static string expect;
        private static string answer;
    }

    public class When_Converting_Binary_To_Base_10
    {
        Establish context = () =>
        {
            input = "1101101";
            expect = 109;
        };

        Because of = () => answer = IPconverter.FromBinary(input);

        It Should_Return_4_Groups_Of_Base10_String = () => answer.ShouldEqual(expect);

        private static string input;
        private static uint expect;
        private static uint answer;
    }

    public class When_Building_An_IP_Address_From_UINT
    {
        Establish context = () =>
        {
            input = 1113346458;
            expect = "66.92.81.154";
        };

        Because of = () => answer = IPconverter.UInt32ToIP(input);

        It Should_Return_A_String_IP = () => answer.ShouldEqual(expect);

        private static uint input;
        private static string expect;
        private static string answer;
    }
}