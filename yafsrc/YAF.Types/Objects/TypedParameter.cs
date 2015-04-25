/* Yet Another Forum.NET
 * Copyright (C) 2003-2005 Bjørnar Henden
 * Copyright (C) 2006-2013 Jaben Cargman
 * Copyright (C) 2014-2015 Ingo Herbote
 * http://www.yetanotherforum.net/
 * 
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at

 * http://www.apache.org/licenses/LICENSE-2.0

 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
namespace YAF.Types
{
  #region Using

  using System;

  using YAF.Types.Interfaces;

  #endregion

  /// <summary>
  /// The typed parameter.
  /// </summary>
  public class TypedParameter : IServiceLocationParameter
  {
    #region Constructors and Destructors

    /// <summary>
    /// Initializes a new instance of the <see cref="TypedParameter"/> class.
    /// </summary>
    /// <param name="type">
    /// The type.
    /// </param>
    /// <param name="value">
    /// The value.
    /// </param>
    public TypedParameter([NotNull] Type type, [NotNull] object value)
    {
      this.Type = type;
      this.Value = value;
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets Type.
    /// </summary>
    public Type Type { get; set; }

    /// <summary>
    /// Gets or sets Value.
    /// </summary>
    public object Value { get; set; }

    #endregion
  }
}