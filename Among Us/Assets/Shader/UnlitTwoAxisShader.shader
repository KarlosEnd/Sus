Shader "Unlit/TwoAxisShader" {
	Properties {
		_Color ("Bg Color", Vector) = (1,1,1,1)
		_CrossHair ("CrossHair Pos", Vector) = (0.5,0.5,0,0)
		_CrossColor ("CrossHair Color", Vector) = (1,1,1,1)
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