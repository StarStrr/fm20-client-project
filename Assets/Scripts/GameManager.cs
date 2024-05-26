using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   [Module]
}

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class ModuleAttribute : Attribute, IConvertible<ModuleAttribute>
{
   // 优先级
   public int Priority { get; private set; }
   // 模块
   public BaseGameModule Module { get; set; }
   /// <summary>
   ///  添加特性才会被当作模块
   /// </summary>
   /// <param name="priority">控制器优先级，值越小越先执行</param>
   public ModuleAttribute(int priority)
   {
      Priority = priority;
   }
   
}