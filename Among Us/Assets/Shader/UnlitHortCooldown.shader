Shader "Unlit/HortCooldown" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_Color ("Cooldown Color", Vector) = (0.5,0.5,0.5,1)
		_Percent ("PercentCool", Float) = 1
		_NormalizedUvs ("NormUvs", Vector) = (0,1,0,0)
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