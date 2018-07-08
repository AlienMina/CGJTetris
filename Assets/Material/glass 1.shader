// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:33626,y:32639,varname:node_4013,prsc:2|diff-1304-RGB,diffpow-4665-OUT,spec-3609-OUT,gloss-7901-OUT,normal-6025-RGB,emission-9577-OUT,alpha-8834-OUT,refract-6419-OUT;n:type:ShaderForge.SFN_Color,id:1304,x:32845,y:32304,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_1304,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4705882,c2:0.4961459,c3:1,c4:1;n:type:ShaderForge.SFN_Fresnel,id:3510,x:32732,y:32786,varname:node_3510,prsc:2|EXP-5729-OUT;n:type:ShaderForge.SFN_Vector1,id:5729,x:32513,y:32835,varname:node_5729,prsc:2,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:1244,x:32611,y:33033,ptovrint:False,ptlb:node_1244,ptin:_node_1244,varname:node_1244,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Multiply,id:2021,x:32911,y:32817,varname:node_2021,prsc:2|A-3510-OUT,B-1244-OUT;n:type:ShaderForge.SFN_Multiply,id:3085,x:33101,y:32881,varname:node_3085,prsc:2|A-2021-OUT,B-2849-RGB,C-8088-OUT;n:type:ShaderForge.SFN_Cubemap,id:2849,x:32881,y:33030,ptovrint:False,ptlb:node_2849,ptin:_node_2849,varname:node_2849,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,cube:9400376fc5b2bd1409b1217680f07e18,pvfc:0;n:type:ShaderForge.SFN_Tex2d,id:1625,x:32865,y:33341,ptovrint:False,ptlb:node_1625,ptin:_node_1625,varname:node_1625,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a2960ffde020f27409e070d92fb2e00b,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Slider,id:7961,x:32337,y:32664,ptovrint:False,ptlb:node_7961,ptin:_node_7961,varname:node_7961,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-2,cur:0.4551282,max:2;n:type:ShaderForge.SFN_Multiply,id:9869,x:32678,y:32554,varname:node_9869,prsc:2|A-6025-RGB,B-7961-OUT;n:type:ShaderForge.SFN_ComponentMask,id:6419,x:32883,y:32517,varname:node_6419,prsc:2,cc1:0,cc2:0,cc3:-1,cc4:-1|IN-9869-OUT;n:type:ShaderForge.SFN_Tex2d,id:6025,x:32349,y:32387,ptovrint:False,ptlb:node_6025,ptin:_node_6025,varname:node_6025,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a695c6aabb14c394198b580418ada95a,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Clamp01,id:9577,x:33306,y:32787,varname:node_9577,prsc:2|IN-3085-OUT;n:type:ShaderForge.SFN_Vector1,id:4665,x:33272,y:32446,varname:node_4665,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:7901,x:33319,y:32722,varname:node_7901,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:8088,x:33046,y:33184,varname:node_8088,prsc:2|A-1625-RGB,B-4938-OUT;n:type:ShaderForge.SFN_Vector1,id:4938,x:32913,y:33229,varname:node_4938,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:3609,x:33280,y:32580,varname:node_3609,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Fresnel,id:8834,x:33334,y:33099,varname:node_8834,prsc:2;proporder:1304-1244-2849-1625-7961-6025;pass:END;sub:END;*/

Shader "Shader Forge/glass" {
    Properties {
        _Color ("Color", Color) = (0.4705882,0.4961459,1,1)
        _node_1244 ("node_1244", Float ) = 2
        _node_2849 ("node_2849", Cube) = "_Skybox" {}
        _node_1625 ("node_1625", 2D) = "white" {}
        _node_7961 ("node_7961", Range(-2, 2)) = 0.4551282
        _node_6025 ("node_6025", 2D) = "bump" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform float4 _Color;
            uniform float _node_1244;
            uniform samplerCUBE _node_2849;
            uniform sampler2D _node_1625; uniform float4 _node_1625_ST;
            uniform float _node_7961;
            uniform sampler2D _node_6025; uniform float4 _node_6025_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _node_6025_var = UnpackNormal(tex2D(_node_6025,TRANSFORM_TEX(i.uv0, _node_6025)));
                float3 normalLocal = _node_6025_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (_node_6025_var.rgb*_node_7961).rr;
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 1.0;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float node_3609 = 0.5;
                float3 specularColor = float3(node_3609,node_3609,node_3609);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = pow(max( 0.0, NdotL), 1.0) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuseColor = _Color.rgb;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _node_1625_var = tex2D(_node_1625,TRANSFORM_TEX(i.uv0, _node_1625));
                float3 emissive = saturate(((pow(1.0-max(0,dot(normalDirection, viewDirection)),0.0)*_node_1244)*texCUBE(_node_2849,viewReflectDirection).rgb*(_node_1625_var.rgb*1.0)));
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(lerp(sceneColor.rgb, finalColor,(1.0-max(0,dot(normalDirection, viewDirection)))),1);
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
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _GrabTexture;
            uniform float4 _Color;
            uniform float _node_1244;
            uniform samplerCUBE _node_2849;
            uniform sampler2D _node_1625; uniform float4 _node_1625_ST;
            uniform float _node_7961;
            uniform sampler2D _node_6025; uniform float4 _node_6025_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float3 tangentDir : TEXCOORD3;
                float3 bitangentDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
                LIGHTING_COORDS(6,7)
                UNITY_FOG_COORDS(8)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _node_6025_var = UnpackNormal(tex2D(_node_6025,TRANSFORM_TEX(i.uv0, _node_6025)));
                float3 normalLocal = _node_6025_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w) + (_node_6025_var.rgb*_node_7961).rr;
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
				float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
///////// Gloss:
                float gloss = 1.0;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float node_3609 = 0.5;
                float3 specularColor = float3(node_3609,node_3609,node_3609);
                float3 directSpecular = attenColor * pow(max(0,dot(halfDirection,normalDirection)),specPow)*specularColor;
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = pow(max( 0.0, NdotL), 1.0) * attenColor;
                float3 diffuseColor = _Color.rgb;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * (1.0-max(0,dot(normalDirection, viewDirection))),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
