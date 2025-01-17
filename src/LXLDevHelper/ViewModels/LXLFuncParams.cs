﻿using Newtonsoft.Json;
using Prism.Mvvm;
using System.Collections.ObjectModel;
namespace LXLDevHelper.ViewModels
{
    /// <summary>
    /// 匿名方法形参描述
    /// </summary>
    public class LXLFuncParamsBase : BindableBase
    {
        [JsonIgnore] public LXLFuncParamsBase Me { get => this; }
        /// <summary>
        /// 参数类型
        /// </summary>
        public string ParamType { get => _paramType; set => SetProperty(ref _paramType, value); }
        private string _paramType =
#if DEBUG
         "string"
#else
""
#endif
            ;
        /// <summary>
        /// 参数名称
        /// </summary>
        public string ParamName { get => _paramName; set => SetProperty(ref _paramName, value); }
        private string _paramName =
#if DEBUG
           "参数名"
#else
""
#endif
            ;
        /// <summary>
        /// 参数可选
        /// </summary>
        public bool Optional { get => _optional; set => SetProperty(ref _optional, value); }
        private bool _optional = false;
        [JsonIgnore] public static ObservableCollection<string> AvaliableTypes { get => MainContentViewModel.AvaliableTypes; }
    }
    /// <summary>
    /// 方法形参描述
    /// </summary>
    public class LXLFuncParams : LXLFuncParamsBase
    {

        /// <summary>
        /// 参数描述
        /// </summary>
        public string Description { get => _description; set => SetProperty(ref _description, value); }
        private string _description =
#if DEBUG
           "参数描述"
#else
""
#endif
            ;
    }
}
