﻿// Copyright (c) https://github.com/licanhua/YWinAppDriver. All rights reserved.
// Licensed under the MIT License.

namespace WinAppDriver.Infra.Communication
{
  public interface IApplication
  {
    public int GetProcessId();
    public IElement GetApplicationRoot();
    public void QuitApplication();
  }

  public interface IApplicationManager
  {
    public IApplication LaunchApplication(Capabilities capabilities);
  }
}
