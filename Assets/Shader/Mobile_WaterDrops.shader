Shader "Mobile/WaterDrops" {
	Properties {
		_Texture ("Texture", 2D) = "black" {}
		_Reflection ("Reflection", Cube) = "white" {}
		_WaterNormal ("Water Normal", 2D) = "bump" {}
		_Drops ("Drops", 2D) = "bump" {}
		_Columns ("Columns", Float) = 0
		_Rows ("Rows", Float) = 0
		_AnimationSpeed ("Animation Speed", Range(0, 50)) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	//CustomEditor "ASEMaterialInspector"
}