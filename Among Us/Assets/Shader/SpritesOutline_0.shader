Shader "Sprites/Outline" {
	Properties {
		_MainTex ("Sprite Texture", 2D) = "white" {}
		_Outline ("Outline", Float) = 0
		_OutlineColor ("OutlineColor", Vector) = (1,1,1,1)
		_AddColor ("AddColor", Vector) = (0,0,0,0)
		[Toggle(OUTLINE_FLIP)] _OutlineFlip ("Interior Outline", Float) = 0
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