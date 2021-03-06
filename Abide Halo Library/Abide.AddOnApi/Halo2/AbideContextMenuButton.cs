﻿using Abide.HaloLibrary;
using Abide.HaloLibrary.Halo2Map;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using YeloDebug;

namespace Abide.AddOnApi.Halo2
{
    /// <summary>
    /// Provides an empty Halo 2 <see cref="AbideMenuButton"/> AddOn which implements the <see cref="IMenuButton{MapFile, IndexEntry, Xbox}"/> interface.
    /// </summary>
    public class AbideContextMenuButton : IContextMenuItem<MapFile, IndexEntry, Xbox>
    {
        /// <summary>
        /// Occurs when the menu button is clicked.
        /// </summary>
        [Category("Abide"), Description("Occurs when the menu button is clicked.")]
        public event EventHandler Click
        {
            add { click += value; }
            remove { click -= value; }
        }
        /// <summary>
        /// Occurs when the AddOn instance is initialized.
        /// </summary>
        [Category("Abide"), Description("Occurs when the AddOn instance is initialized.")]
        public event EventHandler<AddOnHostEventArgs> Initialize
        {
            add { initialize += value; }
            remove { initialize -= value; }
        }
        /// <summary>
        /// Occurs when the host instance loads or reloads a Halo Map instance.
        /// </summary>
        [Category("Abide"), Description("Occurs when the host instance loads or reloads a Halo Map instance.")]
        public event EventHandler MapLoad
        {
            add { mapLoad += value; }
            remove { mapLoad -= value; }
        }
        /// <summary>
        /// Occurs when the host instance changes is changes the selected Index Entry.
        /// </summary>
        [Category("Abide"), Description("Occurs when the host instance changes is changes the selected Index Entry.")]
        public event EventHandler SelectedEntryChanged
        {
            add { selectedEntryChanged += value; }
            remove { selectedEntryChanged -= value; }
        }
        /// <summary>
        /// Occurs when the host instance changes its Xbox connection.
        /// </summary>
        [Category("Abide"), Description("Occurs when the host instance changes its Xbox connection.")]
        public event EventHandler XboxChanged
        {
            add { xboxChanged += value; }
            remove { xboxChanged -= value; }
        }
        /// <summary>
        /// Gets or sets the Halo Map version the AddOn is compatible with.
        /// </summary>
        [Category("Abide"), Description("The Halo Map version the AddOn is compatible with.")]
        public MapVersion MapVersion
        {
            get { return mapVersion; }
            set { mapVersion = value; }
        }
        /// <summary>
        /// Gets or sets the name of the AddOn.
        /// </summary>
        [Category("Abide"), Description("The name of the AddOn.")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Gets or sets the description of the AddOn.
        /// </summary>
        [Category("Abide"), Description("The description of the AddOn.")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// Gets or sets the author of the AddOn.
        /// </summary>
        [Category("Abide"), Description("The author of the AddOn.")]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        /// <summary>
        /// Gets or sets the tag filter of the AddOn.
        /// </summary>
        [Category("Abide"), Description("The tag filter of the AddOn."), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<TagFourCc> TagFilter
        {
            get { return tagFilter; }
            set { tagFilter = value; }
        }
        /// <summary>
        /// Gets or sets whether to use the AddOn's tag filter.
        /// </summary>
        [Category("Abide"), Description("Sets the usabilty of the AddOn's tag filter.")]
        public bool ApplyTagFilter
        {
            get { return applyTagFilter; }
            set { applyTagFilter = value; }
        }
        /// <summary>
        /// Gets or sets the display icon of the AddOn.
        /// </summary>
        [Category("Abide"), Description("The display icon of the AddOn.")]
        public Image Icon
        {
            get { return icon; }
            set { icon = value; }
        }
        /// <summary>
        /// Gets and returns the current Halo Map.
        /// This value can be null.
        /// </summary>
        [Browsable(false)]
        public MapFile Map
        {
            get { return (MapFile)host?.Request(this, "Map"); }
        }
        /// <summary>
        /// Gets and returns the currently selected Index Entry.
        /// This value can be null.
        /// </summary>
        [Browsable(false)]
        public IndexEntry SelectedEntry
        {
            get { return (IndexEntry)host?.Request(this, "SelectedEntry"); }
        }
        /// <summary>
        /// Gets and returns the current Debug Xbox.
        /// This value can be null.
        /// </summary>
        [Browsable(false)]
        public Xbox Xbox
        {
            get { return (Xbox)host?.Request(this, "Xbox"); }
        }
        /// <summary>
        /// Gets and returns the AddOn host.
        /// </summary>
        [Browsable(false)]
        public IHost Host
        {
            get { return host; }
        }

        private event EventHandler click;
        private event EventHandler mapLoad;
        private event EventHandler selectedEntryChanged;
        private event EventHandler xboxChanged;
        private event EventHandler disposing;
        private event EventHandler<AddOnHostEventArgs> initialize;
        private List<TagFourCc> tagFilter = new List<TagFourCc>();
        private bool applyTagFilter = false;
        private MapVersion mapVersion = MapVersion.Halo2;
        private string name;
        private string description;
        private string author;
        private Image icon = null;
        private IHost host;

        /// <summary>
        /// Initializes a new <see cref="AbideMenuButton"/> instance.
        /// </summary>
        public AbideContextMenuButton() { }
        /// <summary>
        /// Occurs when the AddOn instance is being initialized.
        /// </summary>
        /// <param name="e">The AddOn host event arguments.</param>
        protected virtual void OnIntialize(AddOnHostEventArgs e) { }
        /// <summary>
        /// Occurs when the host instance loads or reloads its Halo Map instance.
        /// </summary>
        /// <param name="e">The Event arguments.</param>
        protected virtual void OnMapLoad(EventArgs e) { }
        /// <summary>
        /// Occurs when the host instance changes its debug Xbox connection.
        /// </summary>
        /// <param name="e">The Event Arguments.</param>
        protected virtual void OnXboxChanged(EventArgs e) { }
        /// <summary>
        /// Occurs when the host instance changes its selected Halo Index entry.
        /// </summary>
        /// <param name="e">The Event Arguments.</param>
        protected virtual void OnSelectedEntryChanged(EventArgs e) { }
        /// <summary>
        /// Occurs when the menu button is clicked.
        /// </summary>
        /// <param name="e">The Event Arguments.</param>
        protected virtual void OnClick(EventArgs e) { }
        /// <summary>
        /// Occurs when the AddOn is being disposed.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        protected virtual void OnDispose(EventArgs e) { }

        string IAddOn.Author
        {
            get { return author; }
        }
        string IAddOn.Description
        {
            get { return description; }
        }
        TagFourCc[] ITagFilter.Filter
        {
            get { return tagFilter.ToArray(); }
        }
        bool ITagFilter.ApplyFilter
        {
            get { return applyTagFilter; }
        }
        MapFile IHaloAddOn<MapFile, IndexEntry>.Map
        {
            get { return Map; }
        }
        string IAddOn.Name
        {
            get { return name; }
        }
        IndexEntry IHaloAddOn<MapFile, IndexEntry>.SelectedEntry
        {
            get { return SelectedEntry; }
        }
        MapVersion IHaloAddOn<MapFile, IndexEntry>.Version
        {
            get { return mapVersion; }
        }
        Xbox IDebugXboxAddOn<Xbox>.Xbox
        {
            get { return Xbox; }
        }
        Image IContextMenuItem<MapFile, IndexEntry, Xbox>.Icon
        {
            get { return icon; }
        }

        void IDebugXboxAddOn<Xbox>.DebugXboxChanged()
        {
            //Create Args
            var e = new EventArgs();

            //Xbox Changed
            OnXboxChanged(new EventArgs());

            //Invoke
            xboxChanged?.Invoke(this, e);
        }
        void IAddOn.Initialize(IHost host)
        {
            //Set
            this.host = host;

            //Create Args
            var e = new AddOnHostEventArgs(host);

            //Initialize
            OnIntialize(e);

            //Trigger
            initialize?.Invoke(this, e);
        }
        void IHaloAddOn<MapFile, IndexEntry>.OnMapLoad()
        {
            //Create Args
            var e = new EventArgs();

            //Map Load
            OnMapLoad(e);

            //Invoke
            mapLoad?.Invoke(this, e);
        }
        void IHaloAddOn<MapFile, IndexEntry>.OnSelectedEntryChanged()
        {
            //Create Args
            var e = new EventArgs();

            //Selected Entry Changed
            OnSelectedEntryChanged(e);

            //Invoke
            selectedEntryChanged?.Invoke(this, e);
        }
        void IContextMenuItem<MapFile, IndexEntry, Xbox>.OnClick()
        {
            //Create Args
            var e = new EventArgs();

            //Click
            OnClick(e);

            //Invoke
            click?.Invoke(this, e);
        }
        void IDisposable.Dispose()
        {
            //Create Args
            var e = new EventArgs();

            //Invoke Event
            disposing?.Invoke(this, e);

            //Dispose
            OnDispose(e);
        }
    }
}
