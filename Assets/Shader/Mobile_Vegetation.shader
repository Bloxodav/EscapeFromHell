Shader "Mobile/Vegetation" {
	Properties {
		_Cutoff ("Mask Clip Value", Float) = 0.5
		_BaseRGBAlphaA ("Base (RGB) Alpha (A)", 2D) = "white" {}
		_Turbulence ("Turbulence", Float) = 0.3
		_SpeedTurbulence ("Speed Turbulence", Float) = 0.3
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
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