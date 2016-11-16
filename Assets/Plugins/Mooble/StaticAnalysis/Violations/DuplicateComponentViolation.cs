﻿namespace Mooble.StaticAnalysis.Violation {
  public class DuplicateComponentViolation : IViolation {
    private Rules.DuplicateComponent rule;
    private string gameObjectName;
    private string componentName;
    private int count;

    public DuplicateComponentViolation(Rules.DuplicateComponent r, string o, string c, int n) {
      this.rule = r;
      this.gameObjectName = o;
      this.componentName = c;
      this.count = n;
    }

    public string Format() {
      return string.Format(
        "{0} {1}: there are {2} {3} scripts on {4}",
        this.rule.Level,
        this.rule.Name,
        this.count,
        this.componentName,
        this.gameObjectName);
    }
  }
}