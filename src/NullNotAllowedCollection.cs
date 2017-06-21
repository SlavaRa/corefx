// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.ServiceModel.Syndication
{
    using System;
    using System.Collections.ObjectModel;

    class NullNotAllowedCollection<TCollectionItem> : Collection<TCollectionItem>
        where TCollectionItem : class
    {
        public NullNotAllowedCollection()
            : base()
        {
        }

        protected override void InsertItem(int index, TCollectionItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            base.InsertItem(index, item);
        }

        protected override void SetItem(int index, TCollectionItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            base.SetItem(index, item);
        }
    }
}
