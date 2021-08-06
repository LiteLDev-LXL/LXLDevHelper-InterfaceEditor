﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows;

namespace LXLDevHelper.ViewModels
{
    public class MainContentViewModel : BindableBase
    {
        /// <summary>
        /// 当前正在编辑的类的所有方法集合
        /// </summary>
        public ObservableCollection<LXLDirectory> DirCollection
        {
            get { return _DirCollection; }
            set { SetProperty(ref _DirCollection, value); }
        }
        private ObservableCollection<LXLDirectory> _DirCollection = new() { };
        /// <summary>
        /// 当前正在编辑的文件夹的所有类定义
        /// </summary>
        [JsonIgnore]
        public ObservableCollection<LXLClass> CurrentClassCollection
        {
            get { return _CurrentClassCollection; }
            set { SetProperty(ref _CurrentClassCollection, value); }
        }
        private ObservableCollection<LXLClass> _CurrentClassCollection = new();
        private bool _CurrentClassCollectionHasSet = false;
        [JsonIgnore]
        public bool CurrentClassCollectionHasSet
        {
            get => _CurrentClassCollectionHasSet; set
            {
                SetProperty(ref _CurrentClassCollectionHasSet, value);
                if (!value)//设置false=>未设定，移除当前项
                {
                    CurrentClassCollection = new();
                }
            }
        }
        /// <summary>
        /// 当前正在编辑的类的所有方法集合
        /// </summary>
        [JsonIgnore]
        public LXLClass CurrentClass
        {
            get { return _CurrentClass; }
            set { SetProperty(ref _CurrentClass, value); }
        }
        private LXLClass _CurrentClass = new() { };
        private bool _currentClassHasSet = false;
        public bool CurrentClassHasSet
        {
            get => _currentClassHasSet; set
            {
                SetProperty(ref _currentClassHasSet, value);
                if (!value)//设置false=>未设定，移除当前项
                {
                    CurrentClass = new();
                }
            }
        }
        /// <summary>
        /// 当前正在编辑的类的所有属性集合
        /// </summary>
        //[JsonIgnore]
        //public ObservableCollection<LXLProperty> CurrentPropertyCollection
        //{
        //    get { return _CurrentPropertyCollection; }
        //    set { SetProperty(ref _CurrentPropertyCollection, value); }
        //}
        //private ObservableCollection<LXLProperty> _CurrentPropertyCollection = new() { };
        //private bool _currentPropertyCollectionHasSet = false;
        //[JsonIgnore]
        //public bool CurrentPropertyCollectionHasSet
        //{
        //    get => _currentPropertyCollectionHasSet; set
        //    {
        //        SetProperty(ref _currentPropertyCollectionHasSet, value);
        //        if (!value)//设置false=>未设定，移除当前项
        //        {
        //            CurrentPropertyCollection = new();
        //        }
        //    }
        //}

        /// <summary>
        /// 当前正在编辑的方法定义
        /// </summary>
        [JsonIgnore]
        public LXLFunction CurrentFunc
        {
            get { return _CurrentFunc; }
            set { SetProperty(ref _CurrentFunc, value); }
        }
        private LXLFunction _CurrentFunc = new() { };
        private bool _currentFuncHasSet = false;
        [JsonIgnore]
        public bool CurrentFuncHasSet
        {
            get => _currentFuncHasSet; set
            {
                SetProperty(ref _currentFuncHasSet, value);
                if (!value)//设置false=>未设定，移除当前项
                {
                    CurrentFunc = new();
                }
            }
        }
        //[JsonIgnore]
        //public bool CurrentFuncCollectionHasSet
        //{
        //    get => _currentFuncCollectionHasSet; set
        //    {
        //        SetProperty(ref _currentFuncCollectionHasSet, value);
        //        if (!value)//设置false=>未设定，移除当前项
        //        {
        //            CurrentFuncCollection = new();
        //        }
        //    }
        //}
        /// <summary>
        /// 当前正在编辑的属性定义
        /// </summary>
        [JsonIgnore]
        public LXLProperty CurrentProperty
        {
            get { return _CurrentProperty; }
            set { SetProperty(ref _CurrentProperty, value); }
        }
        private LXLProperty _CurrentProperty = new() { };
        private bool _currentPropertyHasSet = false;
        [JsonIgnore]
        public bool CurrentPropertyHasSet
        {
            get => _currentPropertyHasSet; set
            {
                SetProperty(ref _currentPropertyHasSet, value);
                if (!value)//设置false=>未设定，移除当前项
                {
                    CurrentProperty = new();
                }
            }
        }


        private bool _editProperty = false;
        //[JsonIgnore]
        //public Visibility EditPropertyVisibility
        //{
        //    get => BoolToVisibility(_editProperty); set
        //    {
        //        SetProperty(ref _editProperty, VisibilityToBool(value));
        //        if (value == Visibility.Visible)
        //        { EditFuncVisibility = Visibility.Collapsed; }
        //        else
        //        { CurrentPropertyHasSet = false; }
        //    }
        //}
        [JsonIgnore]
        public bool EditProperty
        {
            get => _editProperty; set
            {
                SetProperty(ref _editProperty, value);
                if (value)
                {
                    EditFunc = false;
                } 
            }
        }
        private bool _editFunc = false;
        //[JsonIgnore]
        //public Visibility EditFuncVisibility
        //{
        //    get => BoolToVisibility(_editFunc); set
        //    {
        //        SetProperty(ref _editFunc, VisibilityToBool(value));
        //        if (value == Visibility.Visible)
        //        { EditPropertyVisibility = Visibility.Collapsed; }
        //        else
        //        { CurrentFuncHasSet = false; }
        //    }
        //}
        [JsonIgnore]
        public bool EditFunc
        {
            get => _editFunc; set
            {
                SetProperty(ref _editFunc, value);
                if (value)
                {
                    EditProperty = false;
                } 
            }
        }
    }
}
