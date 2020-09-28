// ***********************************************************************
// Assembly         : DoToo
// Author           : mick_
// Created          : 09-28-2020
//
// Last Modified By : mick_
// Last Modified On : 09-28-2020
// ***********************************************************************
// <copyright file="TodoItem.cs" Application="DoToo">
//     Copyright (c) Happy Troll Computing. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace DoToo.Models
{
    using System;

    public class TodoItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool Completed { get; set;  }

        public DateTime Due { get; set; }
    }
}
