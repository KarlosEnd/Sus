Shader "Unlit/ColoredWave" {
	Properties {
		_Color ("Color", Vector) = (1,1,0,1)
		_Mag ("Magnitude", Float) = 0.25
		_Freq ("Frequency", Float) = 0.25
		_Speed ("Speed", Float) = 0.25
		_Perlin ("Perlin", Float) = 1
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