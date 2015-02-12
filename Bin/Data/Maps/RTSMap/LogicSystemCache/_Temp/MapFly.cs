using System;
using System.Collections.Generic;
using System.Text;
using Engine;
using Engine.FileSystem;
using Engine.MathEx;
using Engine.Utils;
using Engine.Renderer;
using Engine.PhysicsSystem;
using Engine.SoundSystem;
using Engine.UISystem;
using Engine.EntitySystem;
using Engine.MapSystem;
using ProjectCommon;
using ProjectEntities;

namespace Maps_RTSMap_LogicSystem_LogicSystemScripts
{
	public class MapFly : Engine.EntitySystem.LogicSystem.LogicEntityObject
	{
		Engine.MapSystem.Map __ownerEntity;
		
		public MapFly( Engine.MapSystem.Map ownerEntity )
			: base( ownerEntity )
		{
			this.__ownerEntity = ownerEntity;
		}
		
		public Engine.MapSystem.Map Owner
		{
			get { return __ownerEntity; }
		}
		
		
		public void OnLoad()
		{
			Engine.EntitySystem.LogicClass __class = Engine.EntitySystem.LogicSystemManager.Instance.MapClassManager.GetByName( "MapFly" );
			Engine.EntitySystem.LogicSystem.LogicDesignerMethod __method = (Engine.EntitySystem.LogicSystem.LogicDesignerMethod)__class.GetMethodByName( "OnLoad" );
			__method.Execute( this, new object[ 0 ]{  } );
		}

	}
}
