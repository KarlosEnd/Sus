Shader "Unlit/SpeedLines" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_BackgroungColor ("Background Color", Vector) = (0,0,0,1)
		_BaseColor ("Base Color", Vector) = (1,0,0,1)
		_LineColor ("Line Color", Vector) = (0,0,1,1)
		_LineColor2 ("Line Color 2", Vector) = (0,0,1,1)
		_AdditiveGradient ("AdditiveGradient", Vector) = (0,0,0,0)
		_Speed ("Speed", Float) = -10
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