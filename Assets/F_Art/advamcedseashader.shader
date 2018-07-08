Shader "Custom/advamcedseashader" {
		Properties{
			_Color("Color", Color) = (1,1,1,1) //Color multiplied to the texture
			_MainTex("Albedo (RGB)", 2D) = "white" {} //Texture
			_CelShadingBlurWidth("Cell Shading Blur Width", Range(0,2)) = 0.2 //Blur between thresholds
			_Foam("Foamline Thickness", Range(0,3)) = 0.5
		}
			SubShader{
			Tags{ "RenderType" = "Opaque" }
			LOD 200

			CGPROGRAM

#pragma surface surf Lambert

#pragma fragment frag
#pragma target 3.0


		sampler2D _MainTex;
		sampler2D _RampTex;

		struct Input {
			float2 uv_MainTex;
		};




		struct v2f
		{
			float2 uv : TEXCOORD0;
			UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			float4 scrPos : TEXCOORD1;//
		};

		half _CelShadingBlurWidth;
		fixed4 _Color;
		uniform sampler2D _CameraDepthTexture;
		float _Foam;


		fixed4 surf(Input IN, inout SurfaceOutput o) {

			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
			return c;
		}





		fixed4 frag(v2f i) : SV_Target
		{

			half4 col = tex2D(_MainTex, scrolledUV) * _Tint;// texture times tint;
			half depth = LinearEyeDepth(SAMPLE_DEPTH_TEXTURE_PROJ(_CameraDepthTexture, UNITY_PROJ_COORD(i.scrPos))); // depth
			half4 foamLine = 1 - saturate(_Foam * (depth - i.scrPos.w));// foam line by comparing depth and screenposition
			col += foamLine * _Tint; // add the foam line and tint to the texture
			return col;
		}



		fixed4 LightingToon(SurfaceOutput s, fixed3 lightDir,fixed atten)
		{
			half NdotL = dot(s.Normal, lightDir);  //Value between 0 and 1

			half cel;

			/// 0 | threshold 1  |  blur  | threshold 2 | 1
			/// 0 |**************|<- .5 ->|xxxxxxxxxxxxx| 1

			if (NdotL < 0.5 - _CelShadingBlurWidth / 2)                                         // Outside of the blur but dark
				cel = 0;
			else if (NdotL > 0.5 + _CelShadingBlurWidth / 2)                                    // Outside of the blur but lit
				cel = 1;
			else                                                                                // Inside of the blur 
				cel = 1 - ((0.5 + _CelShadingBlurWidth / 2 - NdotL) / _CelShadingBlurWidth);

			half4 c;

			c.rgb = (cel + 0.3) / 2.5  * s.Albedo * _LightColor0.rgb * atten; // So it does not look too lit
			c.a = s.Alpha;

			return c;
		}







		ENDCG
		}
			FallBack "Diffuse"
	}


