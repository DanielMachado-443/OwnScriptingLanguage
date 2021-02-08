namespace ScriptingTest.Entities {
    class GuardVar {
        public string title { get; set; }
        public int varValue { get; set; }

        public GuardVar(string title, int varValue) {
            this.title = title;
            this.varValue = varValue;
        }
    }
}
