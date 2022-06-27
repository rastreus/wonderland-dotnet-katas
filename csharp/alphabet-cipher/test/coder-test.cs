namespace alphabet_cipher;

using Xunit;
using static alphabet_cipher.coder;

public class coder_test {
    [Fact]
    public void encode_message_with_keyword() {
        Assert.Equal (
            "hmkbxebpxpmyllyrxiiqtoltfgzzv", encode("vigilance", "meetmeontuesdayeveningatseven")
        );
        Assert.Equal (
            "egsgqwtahuiljgs", encode("scones", "meetmebythetree")
        );
    }

    [Fact]
    public void decode_encoded_message_with_keyword() {
        Assert.Equal (
            "meetmeontuesdayeveningatseven", decode("vigilance", "hmkbxebpxpmyllyrxiiqtoltfgzzv")
        );
        Assert.Equal (
            "meetmebythetree", decode("scones", "egsgqwtahuiljgs")
        );
    }

    [Fact]
    public void extract_keyword_from_encrypted_message_and_message() {
        Assert.Equal (
            "vigilance", decipher("opkyfipmfmwcvqoklyhxywgeecpvhelzg", "thequickbrownfoxjumpsoveralazydog")
        );
        Assert.Equal (
            "scones", decipher("hcqxqqtqljmlzhwiivgbsapaiwcenmyu", "packmyboxwithfivedozenliquorjugs")
        );
        Assert.Equal (
            "abcabcx", decipher("hfnlphoontutufa", "hellofromrussia")
        );
    }
}
