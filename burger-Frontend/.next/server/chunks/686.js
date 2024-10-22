exports.id=686,exports.ids=[686],exports.modules={55079:(e,r,t)=>{Promise.resolve().then(t.t.bind(t,12994,23)),Promise.resolve().then(t.t.bind(t,96114,23)),Promise.resolve().then(t.t.bind(t,9727,23)),Promise.resolve().then(t.t.bind(t,79671,23)),Promise.resolve().then(t.t.bind(t,41868,23)),Promise.resolve().then(t.t.bind(t,84759,23))},14388:(e,r,t)=>{Promise.resolve().then(t.bind(t,29394)),Promise.resolve().then(t.bind(t,40776)),Promise.resolve().then(t.bind(t,16574))},35303:()=>{},40776:(e,r,t)=>{"use strict";t.d(r,{default:()=>a});var n=t(10326),i=t(90434),o=t(46226),s=t(77109);function a(){var e;let{data:r,status:t}=(0,s.useSession)(),a=async()=>{await (0,s.signOut)()};return(0,n.jsxs)("nav",{className:"flex px-[50px] py-[15px] bg-zinc-800 text-amber-400 items-center justify-end border-b-4 border-zinc-900",children:[n.jsx(i.default,{href:"/",className:"m-auto ml-0",children:n.jsx(o.default,{height:40,width:40,src:"/images/logo.png",alt:"img-button"})}),"loading"===t?n.jsx("p",{className:"m-[12px]",children:"Loading..."}):r?(0,n.jsxs)(n.Fragment,{children:[(0,n.jsxs)("p",{className:"m-[12px] pr-2",children:["Ol\xe1! ",(e=r.user.name)?e.charAt(0).toUpperCase()+e.slice(1):""]}),n.jsx(i.default,{href:r.isAdmin?"/admin/adminOrders":"/burger-orders",className:"m-[12px] transition duration-500 ease-in-out hover:text-white",children:r.isAdmin?"Pedidos":"Meus pedidos"}),n.jsx(i.default,{href:"/burger-profile",className:"m-[12px] transition duration-500 ease-in-out hover:text-white",children:"Perfil"}),n.jsx("button",{onClick:a,className:"m-[12px] transition duration-500 ease-in-out hover:text-white",children:"Sair"})]}):n.jsx(i.default,{href:"/burger-login",className:"m-[12px] transition duration-500 ease-in-out hover:text-white",children:"Login"})]})}},16574:(e,r,t)=>{"use strict";t.d(r,{default:()=>o});var n=t(10326),i=t(77109);function o({children:e}){return n.jsx(i.SessionProvider,{children:e})}},58585:(e,r,t)=>{"use strict";var n=t(61085);t.o(n,"redirect")&&t.d(r,{redirect:function(){return n.redirect}})},61085:(e,r,t)=>{"use strict";Object.defineProperty(r,"__esModule",{value:!0}),function(e,r){for(var t in r)Object.defineProperty(e,t,{enumerable:!0,get:r[t]})}(r,{ReadonlyURLSearchParams:function(){return s},RedirectType:function(){return n.RedirectType},notFound:function(){return i.notFound},permanentRedirect:function(){return n.permanentRedirect},redirect:function(){return n.redirect}});let n=t(83953),i=t(16399);class o extends Error{constructor(){super("Method unavailable on `ReadonlyURLSearchParams`. Read more: https://nextjs.org/docs/app/api-reference/functions/use-search-params#updating-searchparams")}}class s extends URLSearchParams{append(){throw new o}delete(){throw new o}set(){throw new o}sort(){throw new o}}("function"==typeof r.default||"object"==typeof r.default&&null!==r.default)&&void 0===r.default.__esModule&&(Object.defineProperty(r.default,"__esModule",{value:!0}),Object.assign(r.default,r),e.exports=r.default)},16399:(e,r)=>{"use strict";Object.defineProperty(r,"__esModule",{value:!0}),function(e,r){for(var t in r)Object.defineProperty(e,t,{enumerable:!0,get:r[t]})}(r,{isNotFoundError:function(){return i},notFound:function(){return n}});let t="NEXT_NOT_FOUND";function n(){let e=Error(t);throw e.digest=t,e}function i(e){return"object"==typeof e&&null!==e&&"digest"in e&&e.digest===t}("function"==typeof r.default||"object"==typeof r.default&&null!==r.default)&&void 0===r.default.__esModule&&(Object.defineProperty(r.default,"__esModule",{value:!0}),Object.assign(r.default,r),e.exports=r.default)},8586:(e,r)=>{"use strict";var t;Object.defineProperty(r,"__esModule",{value:!0}),Object.defineProperty(r,"RedirectStatusCode",{enumerable:!0,get:function(){return t}}),function(e){e[e.SeeOther=303]="SeeOther",e[e.TemporaryRedirect=307]="TemporaryRedirect",e[e.PermanentRedirect=308]="PermanentRedirect"}(t||(t={})),("function"==typeof r.default||"object"==typeof r.default&&null!==r.default)&&void 0===r.default.__esModule&&(Object.defineProperty(r.default,"__esModule",{value:!0}),Object.assign(r.default,r),e.exports=r.default)},83953:(e,r,t)=>{"use strict";var n;Object.defineProperty(r,"__esModule",{value:!0}),function(e,r){for(var t in r)Object.defineProperty(e,t,{enumerable:!0,get:r[t]})}(r,{RedirectType:function(){return n},getRedirectError:function(){return d},getRedirectStatusCodeFromError:function(){return m},getRedirectTypeFromError:function(){return p},getURLFromRedirectError:function(){return f},isRedirectError:function(){return l},permanentRedirect:function(){return c},redirect:function(){return u}});let i=t(54580),o=t(72934),s=t(8586),a="NEXT_REDIRECT";function d(e,r,t){void 0===t&&(t=s.RedirectStatusCode.TemporaryRedirect);let n=Error(a);n.digest=a+";"+r+";"+e+";"+t+";";let o=i.requestAsyncStorage.getStore();return o&&(n.mutableCookies=o.mutableCookies),n}function u(e,r){void 0===r&&(r="replace");let t=o.actionAsyncStorage.getStore();throw d(e,r,(null==t?void 0:t.isAction)?s.RedirectStatusCode.SeeOther:s.RedirectStatusCode.TemporaryRedirect)}function c(e,r){void 0===r&&(r="replace");let t=o.actionAsyncStorage.getStore();throw d(e,r,(null==t?void 0:t.isAction)?s.RedirectStatusCode.SeeOther:s.RedirectStatusCode.PermanentRedirect)}function l(e){if("object"!=typeof e||null===e||!("digest"in e)||"string"!=typeof e.digest)return!1;let[r,t,n,i]=e.digest.split(";",4),o=Number(i);return r===a&&("replace"===t||"push"===t)&&"string"==typeof n&&!isNaN(o)&&o in s.RedirectStatusCode}function f(e){return l(e)?e.digest.split(";",3)[2]:null}function p(e){if(!l(e))throw Error("Not a redirect error");return e.digest.split(";",2)[1]}function m(e){if(!l(e))throw Error("Not a redirect error");return Number(e.digest.split(";",4)[3])}(function(e){e.push="push",e.replace="replace"})(n||(n={})),("function"==typeof r.default||"object"==typeof r.default&&null!==r.default)&&void 0===r.default.__esModule&&(Object.defineProperty(r.default,"__esModule",{value:!0}),Object.assign(r.default,r),e.exports=r.default)},5263:(e,r,t)=>{"use strict";t.r(r),t.d(r,{default:()=>i});var n=t(19510);function i(){return n.jsx("div",{className:"fixed inset-0 flex items-center justify-center bg-black bg-opacity-50",children:n.jsx("div",{className:"w-16 h-16 border-8 border-t-8 border-amber-400 border-opacity-1 border-t-white rounded-full animate-spin"})})}t(71159)},4879:(e,r,t)=>{"use strict";t.r(r),t.d(r,{GET:()=>u,POST:()=>u,handler:()=>u});var n=t(75571),i=t.n(n),o=t(53797),s=t(29712),a=t(95687);let d=new(t.n(a)()).Agent({rejectUnauthorized:!1}),u=i()({pages:{signIn:"/burger-login"},providers:[(0,o.Z)({name:"Credentials",credentials:{email:{label:"email",type:"email"},password:{label:"password",type:"password"}},async authorize(e){try{let r=await s.Z.post("http://burgermonapp.somee.com/api/User/login",{email:e.email,password:e.password},{headers:{"Content-Type":"application/json"},httpsAgent:d});console.log("Response data:",r.data);let t=r.data;if("Invalid credentials"===t.message)return Promise.reject(Error("Credenciais Inv\xe1lidas"));if(t&&!0===t.flag)return console.log("DATA",t.user.creation_time),{name:t.user.name,email:t.user.email,isAdmin:t.user.isAdmin,creation_time:t.user.creation_time};return Promise.reject(Error("Usu\xe1rio n\xe3o existe"))}catch(e){Promise.reject(Error("Ocorreu algum erro"))}}})],callbacks:{jwt:async({token:e,user:r})=>(r&&(e.isAdmin=r.isAdmin,e.creation_time=r.creation_time),e),session:async({session:e,token:r})=>(r&&(e.isAdmin=r.isAdmin,e.creation_time=r.creation_time),e)}})},79102:(e,r,t)=>{"use strict";t.r(r),t.d(r,{default:()=>x,metadata:()=>v});var n=t(19510),i=t(1723),o=t.n(i);function s(){return n.jsx("footer",{className:"h-[200px] flex items-center justify-center bg-zinc-800 text-amber-400",children:n.jsx("p",{children:"Burger \xa9 2024 "})})}t(5023);var a=t(68570);let d=(0,a.createProxy)(String.raw`C:\Users\juhab\OneDrive\Documentos\Projects\Burger-Frontend\burger\src\providers\sessionProvider.js`),{__esModule:u,$$typeof:c}=d;d.default;let l=(0,a.createProxy)(String.raw`C:\Users\juhab\OneDrive\Documentos\Projects\Burger-Frontend\burger\src\providers\sessionProvider.js#default`),f=(0,a.createProxy)(String.raw`C:\Users\juhab\OneDrive\Documentos\Projects\Burger-Frontend\burger\src\app\components\Navbar\Navbar.js`),{__esModule:p,$$typeof:m}=f;f.default;let h=(0,a.createProxy)(String.raw`C:\Users\juhab\OneDrive\Documentos\Projects\Burger-Frontend\burger\src\app\components\Navbar\Navbar.js#default`);var g=t(96557);t(97001);var b=t(71159),j=t(5263);let v={title:"Burger"};function x({children:e}){return(0,n.jsxs)("html",{lang:"en",children:[n.jsx("head",{children:n.jsx("link",{rel:"preload",href:"/"})}),n.jsx("body",{className:`${o().className} flex flex-col min-h-screen`,children:(0,n.jsxs)(l,{children:[n.jsx(g.Ix,{position:"top-center",autoClose:2e3}),(0,n.jsxs)(b.Suspense,{fallback:n.jsx(j.default,{}),children:[n.jsx(h,{}),n.jsx("main",{className:"flex-grow",children:e}),n.jsx(s,{})]})]})})]})}},73881:(e,r,t)=>{"use strict";t.r(r),t.d(r,{default:()=>i});var n=t(66621);let i=e=>[{type:"image/x-icon",sizes:"16x16",url:(0,n.fillMetadataSegment)(".",e.params,"favicon.ico")+""}]},5023:()=>{}};