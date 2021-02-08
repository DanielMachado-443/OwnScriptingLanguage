namespace System {
    static class StringExtension {
        public static bool intTest(this string thisObj) {

            int number;
            if(Int32.TryParse(thisObj, out number)) {
                return true;
            }
            return false;
        }
    }
}
