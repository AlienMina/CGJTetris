// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:35281,y:32051,varname:node_9361,prsc:2|custl-9871-OUT,olwid-5900-OUT,olcol-8961-RGB;n:type:ShaderForge.SFN_LightVector,id:2094,x:33931,y:32805,varname:node_2094,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:7525,x:33931,y:32964,prsc:2,pt:False;n:type:ShaderForge.SFN_Dot,id:4816,x:34131,y:32805,varname:node_4816,prsc:2,dt:4|A-2094-OUT,B-7525-OUT;n:type:ShaderForge.SFN_Multiply,id:3654,x:34350,y:32805,varname:node_3654,prsc:2|A-4816-OUT,B-882-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:882,x:34131,y:32964,varname:node_882,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:7806,x:34368,y:31896,ptovrint:False,ptlb:MainTex,ptin:_MainTex,cmnt:An optional overlay texture e.g. for eyes,varname:node_7806,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Posterize,id:461,x:34606,y:32805,cmnt:Basic toon lighting posterized to 2 levels,varname:node_461,prsc:2|IN-3654-OUT,STPS-9485-OUT;n:type:ShaderForge.SFN_Vector1,id:9485,x:34606,y:32969,varname:node_9485,prsc:2,v1:2;n:type:ShaderForge.SFN_Tex2d,id:2226,x:33287,y:32411,ptovrint:False,ptlb:DotTex,ptin:_DotTex,varname:node_2226,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:3964d3a39ac45f449b221a18624db7e6,ntxv:0,isnm:False|UVIN-7432-UVOUT;n:type:ShaderForge.SFN_ScreenPos,id:8945,x:32003,y:32408,cmnt:Using screen UVs makes dots face the screen,varname:node_8945,prsc:2,sctp:0;n:type:ShaderForge.SFN_Multiply,id:6910,x:32548,y:32409,varname:node_6910,prsc:2|A-6131-OUT,B-5613-OUT;n:type:ShaderForge.SFN_ValueProperty,id:8683,x:32551,y:32747,ptovrint:False,ptlb:DotSize,ptin:_DotSize,varname:node_8683,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:4;n:type:ShaderForge.SFN_Lerp,id:6623,x:34362,y:32247,cmnt:Combine colors based on lighting,varname:node_6623,prsc:2|A-4804-OUT,B-5390-RGB,T-461-OUT;n:type:ShaderForge.SFN_Lerp,id:3016,x:34601,y:32038,varname:node_3016,prsc:2|A-7806-RGB,B-6623-OUT,T-1098-OUT;n:type:ShaderForge.SFN_OneMinus,id:1098,x:34601,y:31896,varname:node_1098,prsc:2|IN-7806-A;n:type:ShaderForge.SFN_Lerp,id:7929,x:33791,y:32293,cmnt:Combine dots with the dark color,varname:node_7929,prsc:2|A-2252-OUT,B-8095-RGB,T-2226-RGB;n:type:ShaderForge.SFN_ScreenParameters,id:6694,x:31785,y:32585,cmnt:Multiply by aspect ratio to make dot texture square,varname:node_6694,prsc:2;n:type:ShaderForge.SFN_Divide,id:4126,x:32001,y:32585,varname:node_4126,prsc:2|A-6694-PXH,B-6694-PXW;n:type:ShaderForge.SFN_Multiply,id:8942,x:32235,y:32585,varname:node_8942,prsc:2|A-8945-V,B-4126-OUT;n:type:ShaderForge.SFN_Append,id:6131,x:32237,y:32408,varname:node_6131,prsc:2|A-8945-U,B-8942-OUT;n:type:ShaderForge.SFN_Color,id:8961,x:34971,y:32544,ptovrint:False,ptlb:OutlineColor,ptin:_OutlineColor,varname:node_8961,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Slider,id:5900,x:34755,y:32412,ptovrint:False,ptlb:OutlineWidth,ptin:_OutlineWidth,cmnt:Optional if not using an edge detection screen effect,varname:node_5900,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:2;n:type:ShaderForge.SFN_Fresnel,id:1243,x:34125,y:32606,cmnt:Gives a simple rim light effect,varname:node_1243,prsc:2|EXP-9076-OUT;n:type:ShaderForge.SFN_Posterize,id:7558,x:34331,y:32606,varname:node_7558,prsc:2|IN-1243-OUT,STPS-3954-OUT;n:type:ShaderForge.SFN_Vector1,id:3954,x:34125,y:32745,varname:node_3954,prsc:2,v1:2;n:type:ShaderForge.SFN_Reciprocal,id:9076,x:33933,y:32596,varname:node_9076,prsc:2|IN-9677-OUT;n:type:ShaderForge.SFN_Lerp,id:4804,x:33971,y:32209,cmnt:Combine dots and dark with primary rim light,varname:node_4804,prsc:2|A-5390-RGB,B-7929-OUT,T-9543-OUT;n:type:ShaderForge.SFN_OneMinus,id:9543,x:34535,y:32606,varname:node_9543,prsc:2|IN-7558-OUT;n:type:ShaderForge.SFN_Slider,id:9677,x:33553,y:32596,ptovrint:False,ptlb:FresnelWidth,ptin:_FresnelWidth,varname:node_9677,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;n:type:ShaderForge.SFN_SwitchProperty,id:1131,x:34847,y:32219,ptovrint:False,ptlb:LayerMainTex,ptin:_LayerMainTex,varname:node_1131,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-6623-OUT,B-3016-OUT;n:type:ShaderForge.SFN_ViewPosition,id:1154,x:32337,y:32915,varname:node_1154,prsc:2;n:type:ShaderForge.SFN_Distance,id:6766,x:32551,y:32915,cmnt:Scale dots based on camera distance,varname:node_6766,prsc:2|A-2176-XYZ,B-1154-XYZ;n:type:ShaderForge.SFN_ObjectPosition,id:2176,x:32337,y:32786,varname:node_2176,prsc:2;n:type:ShaderForge.SFN_Divide,id:5613,x:32551,y:32597,varname:node_5613,prsc:2|A-6766-OUT,B-8683-OUT;n:type:ShaderForge.SFN_Rotator,id:7432,x:33015,y:32409,cmnt:Rotate dots based on view,varname:node_7432,prsc:2|UVIN-7369-OUT,ANG-5585-OUT;n:type:ShaderForge.SFN_Slider,id:3535,x:32925,y:32940,ptovrint:False,ptlb:DotRotation,ptin:_DotRotation,varname:node_3535,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:360;n:type:ShaderForge.SFN_Pi,id:2935,x:33082,y:32742,varname:node_2935,prsc:2;n:type:ShaderForge.SFN_Divide,id:43,x:33254,y:32742,varname:node_43,prsc:2|A-2935-OUT,B-9246-OUT;n:type:ShaderForge.SFN_Vector1,id:9246,x:33082,y:32862,varname:node_9246,prsc:2,v1:180;n:type:ShaderForge.SFN_Multiply,id:5585,x:33254,y:32922,cmnt:I prefer degrees,varname:node_5585,prsc:2|A-43-OUT,B-3535-OUT;n:type:ShaderForge.SFN_RemapRange,id:7369,x:32744,y:32409,varname:node_7369,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-6910-OUT;n:type:ShaderForge.SFN_Tex2d,id:5390,x:33287,y:31803,ptovrint:False,ptlb:ColorTex,ptin:_ColorTex,varname:node_5390,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-9397-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:8095,x:33287,y:32198,ptovrint:False,ptlb:DarkColorTex,ptin:_DarkColorTex,varname:node_8095,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-9397-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:3056,x:32847,y:31911,ptovrint:False,ptlb:DotColorTex,ptin:_DotColorTex,varname:node_3056,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-9397-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:9397,x:32569,y:31782,varname:node_9397,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Relay,id:9871,x:34888,y:32003,cmnt:Toon Comic Shader by Chris Chung - www.chrischung.com,varname:node_9871,prsc:2|IN-1131-OUT;n:type:ShaderForge.SFN_Lerp,id:2252,x:33415,y:32117,varname:node_2252,prsc:2|A-3056-RGB,B-2967-OUT,T-9403-OUT;n:type:ShaderForge.SFN_Slider,id:9403,x:32826,y:32306,ptovrint:False,ptlb:changecolor,ptin:_changecolor,varname:node_9403,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.579238,max:5;n:type:ShaderForge.SFN_Vector3,id:2967,x:32983,y:32100,varname:node_2967,prsc:2,v1:0.741785,v2:0.75,v3:0.1544118;n:type:ShaderForge.SFN_Time,id:2369,x:32506,y:32132,varname:node_2369,prsc:2;n:type:ShaderForge.SFN_Sin,id:8898,x:33049,y:32185,varname:node_8898,prsc:2|IN-2369-T;n:type:ShaderForge.SFN_Divide,id:407,x:32789,y:32250,varname:node_407,prsc:2|A-2369-TDB,B-3853-OUT;n:type:ShaderForge.SFN_Vector1,id:3853,x:32548,y:32250,varname:node_3853,prsc:2,v1:2;proporder:7806-5390-8095-3056-2226-8683-3535-9677-5900-8961-1131-9403;pass:END;sub:END;*/

Shader "Shader Forge/ToonComicTexture" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _ColorTex ("ColorTex", 2D) = "white" {}
        _DarkColorTex ("DarkColorTex", 2D) = "white" {}
        _DotColorTex ("DotColorTex", 2D) = "white" {}
        _DotTex ("DotTex", 2D) = "white" {}
        _DotSize ("DotSize", Float ) = 4
        _DotRotation ("DotRotation", Range(0, 360)) = 0
        _FresnelWidth ("FresnelWidth", Range(0, 10)) = 0
        _OutlineWidth ("OutlineWidth", Range(0, 2)) = 0
        _OutlineColor ("OutlineColor", Color) = (0,0,0,1)
        [MaterialToggle] _LayerMainTex ("LayerMainTex", Float ) = 0
        _changecolor ("changecolor", Range(0, 5)) = 1.579238
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 xboxone ps4 n3ds wiiu 
            #pragma target 3.0
            uniform float4 _OutlineColor;
            uniform float _OutlineWidth;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                UNITY_FOG_COORDS(0)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( float4(v.vertex.xyz + v.normal*_OutlineWidth,1) );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                return fixed4(_OutlineColor.rgb,0);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 xboxone ps4 n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _DotTex; uniform float4 _DotTex_ST;
            uniform float _DotSize;
            uniform float _FresnelWidth;
            uniform fixed _LayerMainTex;
            uniform float _DotRotation;
            uniform sampler2D _ColorTex; uniform float4 _ColorTex_ST;
            uniform sampler2D _DarkColorTex; uniform float4 _DarkColorTex_ST;
            uniform sampler2D _DotColorTex; uniform float4 _DotColorTex_ST;
            uniform float _changecolor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _ColorTex_var = tex2D(_ColorTex,TRANSFORM_TEX(i.uv0, _ColorTex));
                float4 _DotColorTex_var = tex2D(_DotColorTex,TRANSFORM_TEX(i.uv0, _DotColorTex));
                float4 _DarkColorTex_var = tex2D(_DarkColorTex,TRANSFORM_TEX(i.uv0, _DarkColorTex));
                float node_7432_ang = ((3.141592654/180.0)*_DotRotation);
                float node_7432_spd = 1.0;
                float node_7432_cos = cos(node_7432_spd*node_7432_ang);
                float node_7432_sin = sin(node_7432_spd*node_7432_ang);
                float2 node_7432_piv = float2(0.5,0.5);
                float2 node_7432 = (mul(((float2((sceneUVs * 2 - 1).r,((sceneUVs * 2 - 1).g*(_ScreenParams.g/_ScreenParams.r)))*(distance(objPos.rgb,_WorldSpaceCameraPos)/_DotSize))*0.5+0.5)-node_7432_piv,float2x2( node_7432_cos, -node_7432_sin, node_7432_sin, node_7432_cos))+node_7432_piv); // Rotate dots based on view
                float4 _DotTex_var = tex2D(_DotTex,TRANSFORM_TEX(node_7432, _DotTex));
                float node_3954 = 2.0;
                float node_9485 = 2.0;
                float3 node_6623 = lerp(lerp(_ColorTex_var.rgb,lerp(lerp(_DotColorTex_var.rgb,float3(0.741785,0.75,0.1544118),_changecolor),_DarkColorTex_var.rgb,_DotTex_var.rgb),(1.0 - floor(pow(1.0-max(0,dot(normalDirection, viewDirection)),(1.0 / _FresnelWidth)) * node_3954) / (node_3954 - 1))),_ColorTex_var.rgb,floor((0.5*dot(lightDirection,i.normalDir)+0.5*attenuation) * node_9485) / (node_9485 - 1)); // Combine colors based on lighting
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex)); // An optional overlay texture e.g. for eyes
                float3 finalColor = lerp( node_6623, lerp(_MainTex_var.rgb,node_6623,(1.0 - _MainTex_var.a)), _LayerMainTex );
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            Cull Off
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 xboxone ps4 n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform sampler2D _DotTex; uniform float4 _DotTex_ST;
            uniform float _DotSize;
            uniform float _FresnelWidth;
            uniform fixed _LayerMainTex;
            uniform float _DotRotation;
            uniform sampler2D _ColorTex; uniform float4 _ColorTex_ST;
            uniform sampler2D _DarkColorTex; uniform float4 _DarkColorTex_ST;
            uniform sampler2D _DotColorTex; uniform float4 _DotColorTex_ST;
            uniform float _changecolor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                float4 objPos = mul ( unity_ObjectToWorld, float4(0,0,0,1) );
                i.normalDir = normalize(i.normalDir);
                i.normalDir *= faceSign;
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _ColorTex_var = tex2D(_ColorTex,TRANSFORM_TEX(i.uv0, _ColorTex));
                float4 _DotColorTex_var = tex2D(_DotColorTex,TRANSFORM_TEX(i.uv0, _DotColorTex));
                float4 _DarkColorTex_var = tex2D(_DarkColorTex,TRANSFORM_TEX(i.uv0, _DarkColorTex));
                float node_7432_ang = ((3.141592654/180.0)*_DotRotation);
                float node_7432_spd = 1.0;
                float node_7432_cos = cos(node_7432_spd*node_7432_ang);
                float node_7432_sin = sin(node_7432_spd*node_7432_ang);
                float2 node_7432_piv = float2(0.5,0.5);
                float2 node_7432 = (mul(((float2((sceneUVs * 2 - 1).r,((sceneUVs * 2 - 1).g*(_ScreenParams.g/_ScreenParams.r)))*(distance(objPos.rgb,_WorldSpaceCameraPos)/_DotSize))*0.5+0.5)-node_7432_piv,float2x2( node_7432_cos, -node_7432_sin, node_7432_sin, node_7432_cos))+node_7432_piv); // Rotate dots based on view
                float4 _DotTex_var = tex2D(_DotTex,TRANSFORM_TEX(node_7432, _DotTex));
                float node_3954 = 2.0;
                float node_9485 = 2.0;
                float3 node_6623 = lerp(lerp(_ColorTex_var.rgb,lerp(lerp(_DotColorTex_var.rgb,float3(0.741785,0.75,0.1544118),_changecolor),_DarkColorTex_var.rgb,_DotTex_var.rgb),(1.0 - floor(pow(1.0-max(0,dot(normalDirection, viewDirection)),(1.0 / _FresnelWidth)) * node_3954) / (node_3954 - 1))),_ColorTex_var.rgb,floor((0.5*dot(lightDirection,i.normalDir)+0.5*attenuation) * node_9485) / (node_9485 - 1)); // Combine colors based on lighting
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex)); // An optional overlay texture e.g. for eyes
                float3 finalColor = lerp( node_6623, lerp(_MainTex_var.rgb,node_6623,(1.0 - _MainTex_var.a)), _LayerMainTex );
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 xboxone ps4 n3ds wiiu 
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
