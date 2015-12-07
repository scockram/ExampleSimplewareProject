using ScanIP;
using System;

public class SimpleUserAction : UserAction
{
  Action action;

  public SimpleUserAction(string ribbon, string group, string name, Action action) : base(ribbon, group, name)
  {
    this.action = action;
    App.GetInstance().AddUserAction(this);
  }

  public override void OnActivated()
  {
    action();
  }
}

