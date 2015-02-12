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

namespace Maps_CutSceneDemo_LogicSystem_LogicSystemScripts
{
	public class TestLamp_Move : Engine.EntitySystem.LogicSystem.LogicEntityObject
	{
		Engine.MapSystem.MapObject __ownerEntity;
		
		public TestLamp_Move( Engine.MapSystem.MapObject ownerEntity )
			: base( ownerEntity )
		{
			this.__ownerEntity = ownerEntity;
			ownerEntity.Tick += delegate( Engine.EntitySystem.Entity __entity ) { if( Engine.EntitySystem.LogicSystemManager.Instance != null )Tick(  ); };
		}
		
		public Engine.MapSystem.MapObject Owner
		{
			get { return __ownerEntity; }
		}
		
		public float moveTime;
		
		public void Tick()
		{
			MapCurve mapCurve = (MapCurve)Entities.Instance.GetByName("MapCurve_MoveLamp");
			
			moveTime += Entity.TickDelta;
			if(moveTime >= mapCurve.GetCurveMaxTime())
				moveTime -= mapCurve.GetCurveMaxTime();
			
			Vec3 center = new Vec3(0,0,2);
			
			Owner.Position = mapCurve.CalculateCurvePointByTime(moveTime);
			
			Vec3 diff = center - Owner.Position;
			Radian horizontalAngle = MathFunctions.ATan( diff.Y, diff.X );
			Radian verticalAngle = MathFunctions.ATan( diff.Z, diff.ToVec2().Length() );
			Owner.Rotation = new Angles( 0, 0, -horizontalAngle.InDegrees() ).ToQuat() * 
				new Angles( 0, verticalAngle.InDegrees(), 0 ).ToQuat();
			
		}

	}
}
