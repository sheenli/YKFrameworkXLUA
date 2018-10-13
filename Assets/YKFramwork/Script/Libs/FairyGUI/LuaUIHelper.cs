using System;
using System.Collections.Generic;
using FairyGUI.Utils;
using XLua;

namespace FairyGUI
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class LuaUIHelper
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="url"></param>
		/// <param name="luaClass"></param>
		public static void SetExtension(string url, System.Type baseType, LuaFunction extendFunction)
		{
			UIObjectFactory.SetPackageItemExtension(url, () => {
				GComponent gcom = (GComponent)Activator.CreateInstance(baseType);
				gcom.data = extendFunction;
				return gcom;
			});
		}
        [CSharpCallLua]
        public interface ILuaComponent
        {
            void Init();
        }


        [XLua.BlackList]
		public static LuaTable ConnectLua(GComponent gcom)
		{
			LuaTable _peerTable = null;
			LuaFunction extendFunction = gcom.data as LuaFunction;
			if (extendFunction!=null)
			{
				gcom.data = null;

                object[] obj = extendFunction.Call(gcom);
                _peerTable = obj[0] as LuaTable;
                _peerTable.Set("csuserdata", gcom);

            }
            ILuaComponent c = _peerTable.Cast<ILuaComponent>();
            c.Init();
            return _peerTable;
		}
	}

    public class GLuaComponent : GComponent
    {
        public LuaTable Lua;

        [XLua.BlackList]
        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Lua = LuaUIHelper.ConnectLua(this);
            
        }

        public override void Dispose()
		{
			base.Dispose();

			if (Lua != null)
                Lua.Dispose();
		}
	}

	public class GLuaLabel : GLabel
	{
        public LuaTable Lua;

        [XLua.BlackList]
		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

            Lua = LuaUIHelper.ConnectLua(this);
		}

		public override void Dispose()
		{
			base.Dispose();

			if (Lua != null)
                Lua.Dispose();
		}
	}

	public class GLuaButton : GButton
	{
        public LuaTable Lua;

        [XLua.BlackList]
		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

            Lua = LuaUIHelper.ConnectLua(this);
		}

		public override void Dispose()
		{
			base.Dispose();

			if (Lua != null)
                Lua.Dispose();
		}
	}

	public class GLuaProgressBar : GProgressBar
	{
        public LuaTable Lua;

        [XLua.BlackList]
		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

            Lua = LuaUIHelper.ConnectLua(this);
		}

		public override void Dispose()
		{
			base.Dispose();

			if (Lua != null)
                Lua.Dispose();
		}
	}

	public class GLuaSlider : GSlider
	{
        public LuaTable Lua;

        [XLua.BlackList]
		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

            Lua = LuaUIHelper.ConnectLua(this);
		}

		public override void Dispose()
		{
			base.Dispose();

			if (Lua != null)
                Lua.Dispose();
		}
	}

	public class GLuaComboBox : GComboBox
	{
        public LuaTable Lua;

        [XLua.BlackList]
		public override void ConstructFromXML(XML xml)
		{
			base.ConstructFromXML(xml);

            Lua = LuaUIHelper.ConnectLua(this);
		}

		public override void Dispose()
		{
			base.Dispose();

			if (Lua != null)
                Lua.Dispose();
		}
	}
    #region LuaLuaWindow
    [CSharpCallLua]
    public interface ILuaWindow
    {
        void OnInit();
        void DoHideAnimation();
        void DoShowAnimation();
        void OnShown();
        void OnHide();
    }
    public class LuaWindow : Window ,YKSupportLua.ILuaNeedExtendCS
	{
		LuaTable _peerTable;
        ILuaWindow callback;
        [XLua.BlackList]
        public void SetLuaTalbe(LuaTable peerTable)
		{
			_peerTable = peerTable;
            callback = peerTable.Cast<ILuaWindow>();
        }

		public override void Dispose()
		{
			base.Dispose();

			if (_peerTable != null)
				_peerTable.Dispose();
		}

		protected override void OnInit()
		{
			if (callback != null)
			{
                callback.OnInit();
			}
		}

		protected override void DoHideAnimation()
		{
			if (callback != null)
			{
                callback.DoHideAnimation();
			}
		}

		protected override void DoShowAnimation()
		{
			if (callback != null)
			{
                callback.DoShowAnimation();
			}
			else
				base.DoShowAnimation();
		}

		protected override void OnShown()
		{
			base.OnShown();

			if (callback != null)
			{
                callback.OnShown();
			}
		}

		protected override void OnHide()
		{
			base.OnHide();

			if (callback != null)
			{
                callback.OnHide();
			}
		}
    }
    #endregion

}