﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LectureStream.Services
{
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return ImageSource.FromResource(ResourceId);
        }
    }
}
