Shader "Unlit/RadialMenuShader" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_Color ("Primary Color", Vector) = (1,1,1,1)
		_EdgeColor ("Outline Color", Vector) = (0,0,0,1)
		_SelectedColor ("Selected Primary Color", Vector) = (0,1,0,1)
		_SelectedEdgeColor ("Selected Outline Color", Vector) = (0,0.4,0,1)
		_NumSlices ("Current number of slices", Float) = 1
		_SelectedSlice ("Currently Selected Slice", Float) = -1
	}
	
	//DummyShaderTextExporter - One Sided
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard fullforwardshadows
#pragma target 3.0
		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
		}
		ENDCG
	}
}