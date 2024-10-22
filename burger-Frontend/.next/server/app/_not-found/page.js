(()=>{var e={};e.id=409,e.ids=[409],e.modules={47849:e=>{"use strict";e.exports=require("next/dist/client/components/action-async-storage.external")},72934:e=>{"use strict";e.exports=require("next/dist/client/components/action-async-storage.external.js")},55403:e=>{"use strict";e.exports=require("next/dist/client/components/request-async-storage.external")},54580:e=>{"use strict";e.exports=require("next/dist/client/components/request-async-storage.external.js")},94749:e=>{"use strict";e.exports=require("next/dist/client/components/static-generation-async-storage.external")},45869:e=>{"use strict";e.exports=require("next/dist/client/components/static-generation-async-storage.external.js")},20399:e=>{"use strict";e.exports=require("next/dist/compiled/next-server/app-page.runtime.prod.js")},21152:(e,t,r)=>{"use strict";r.r(t),r.d(t,{GlobalError:()=>i.a,__next_app__:()=>f,originalPathname:()=>c,pages:()=>d,routeModule:()=>p,tree:()=>u}),r(7352),r(35866),r(79102);var n=r(23191),s=r(88716),o=r(37922),i=r.n(o),a=r(95231),l={};for(let e in a)0>["default","tree","pages","GlobalError","originalPathname","__next_app__","routeModule"].indexOf(e)&&(l[e]=()=>a[e]);r.d(t,l);let u=["",{children:["/_not-found",{children:["__PAGE__",{},{page:[()=>Promise.resolve().then(r.t.bind(r,35866,23)),"next/dist/client/components/not-found-error"]}]},{}]},{layout:[()=>Promise.resolve().then(r.bind(r,79102)),"C:\\Users\\juhab\\OneDrive\\Documentos\\Projects\\Burger-Frontend\\burger\\src\\app\\layout.js"],"not-found":[()=>Promise.resolve().then(r.t.bind(r,35866,23)),"next/dist/client/components/not-found-error"]}],d=[],c="/_not-found/page",f={require:r,loadChunk:()=>Promise.resolve()},p=new n.AppPageRouteModule({definition:{kind:s.x.APP_PAGE,page:"/_not-found/page",pathname:"/_not-found",bundlePath:"",filename:"",appPaths:[]},userland:{loaderTree:u}})},55079:(e,t,r)=>{Promise.resolve().then(r.t.bind(r,12994,23)),Promise.resolve().then(r.t.bind(r,96114,23)),Promise.resolve().then(r.t.bind(r,9727,23)),Promise.resolve().then(r.t.bind(r,79671,23)),Promise.resolve().then(r.t.bind(r,41868,23)),Promise.resolve().then(r.t.bind(r,84759,23))},14388:(e,t,r)=>{Promise.resolve().then(r.bind(r,29394)),Promise.resolve().then(r.bind(r,40776)),Promise.resolve().then(r.bind(r,16574))},40776:(e,t,r)=>{"use strict";r.d(t,{default:()=>a});var n=r(10326),s=r(90434),o=r(46226),i=r(77109);function a(){var e;let{data:t,status:r}=(0,i.useSession)(),a=async()=>{await (0,i.signOut)()};return(0,n.jsxs)("nav",{className:"flex px-[50px] py-[15px] bg-zinc-800 text-amber-400 items-center justify-end border-b-4 border-zinc-900",children:[n.jsx(s.default,{href:"/",className:"m-auto ml-0",children:n.jsx(o.default,{height:40,width:40,src:"/images/logo.png",alt:"img-button"})}),"loading"===r?n.jsx("p",{className:"m-[12px]",children:"Loading..."}):t?(0,n.jsxs)(n.Fragment,{children:[(0,n.jsxs)("p",{className:"m-[12px] pr-2",children:["Ol\xe1! ",(e=t.user.name)?e.charAt(0).toUpperCase()+e.slice(1):""]}),n.jsx(s.default,{href:t.isAdmin?"/admin/adminOrders":"/burger-orders",className:"m-[12px] transition duration-500 ease-in-out hover:text-white",children:t.isAdmin?"Pedidos":"Meus pedidos"}),n.jsx(s.default,{href:"/burger-profile",className:"m-[12px] transition duration-500 ease-in-out hover:text-white",children:"Perfil"}),n.jsx("button",{onClick:a,className:"m-[12px] transition duration-500 ease-in-out hover:text-white",children:"Sair"})]}):n.jsx(s.default,{href:"/burger-login",className:"m-[12px] transition duration-500 ease-in-out hover:text-white",children:"Login"})]})}},16574:(e,t,r)=>{"use strict";r.d(t,{default:()=>o});var n=r(10326),s=r(77109);function o({children:e}){return n.jsx(s.SessionProvider,{children:e})}},16399:(e,t)=>{"use strict";Object.defineProperty(t,"__esModule",{value:!0}),function(e,t){for(var r in t)Object.defineProperty(e,r,{enumerable:!0,get:t[r]})}(t,{isNotFoundError:function(){return s},notFound:function(){return n}});let r="NEXT_NOT_FOUND";function n(){let e=Error(r);throw e.digest=r,e}function s(e){return"object"==typeof e&&null!==e&&"digest"in e&&e.digest===r}("function"==typeof t.default||"object"==typeof t.default&&null!==t.default)&&void 0===t.default.__esModule&&(Object.defineProperty(t.default,"__esModule",{value:!0}),Object.assign(t.default,t),e.exports=t.default)},7352:(e,t,r)=>{"use strict";Object.defineProperty(t,"__esModule",{value:!0}),function(e,t){for(var r in t)Object.defineProperty(e,r,{enumerable:!0,get:t[r]})}(t,{PARALLEL_ROUTE_DEFAULT_PATH:function(){return s},default:function(){return o}});let n=r(16399),s="next/dist/client/components/parallel-route-default.js";function o(){(0,n.notFound)()}("function"==typeof t.default||"object"==typeof t.default&&null!==t.default)&&void 0===t.default.__esModule&&(Object.defineProperty(t.default,"__esModule",{value:!0}),Object.assign(t.default,t),e.exports=t.default)},5263:(e,t,r)=>{"use strict";r.r(t),r.d(t,{default:()=>s});var n=r(19510);function s(){return n.jsx("div",{className:"fixed inset-0 flex items-center justify-center bg-black bg-opacity-50",children:n.jsx("div",{className:"w-16 h-16 border-8 border-t-8 border-amber-400 border-opacity-1 border-t-white rounded-full animate-spin"})})}r(71159)},79102:(e,t,r)=>{"use strict";r.r(t),r.d(t,{default:()=>v,metadata:()=>j});var n=r(19510),s=r(1723),o=r.n(s);function i(){return n.jsx("footer",{className:"h-[200px] flex items-center justify-center bg-zinc-800 text-amber-400",children:n.jsx("p",{children:"Burger \xa9 2024 "})})}r(5023);var a=r(68570);let l=(0,a.createProxy)(String.raw`C:\Users\juhab\OneDrive\Documentos\Projects\Burger-Frontend\burger\src\providers\sessionProvider.js`),{__esModule:u,$$typeof:d}=l;l.default;let c=(0,a.createProxy)(String.raw`C:\Users\juhab\OneDrive\Documentos\Projects\Burger-Frontend\burger\src\providers\sessionProvider.js#default`),f=(0,a.createProxy)(String.raw`C:\Users\juhab\OneDrive\Documentos\Projects\Burger-Frontend\burger\src\app\components\Navbar\Navbar.js`),{__esModule:p,$$typeof:x}=f;f.default;let m=(0,a.createProxy)(String.raw`C:\Users\juhab\OneDrive\Documentos\Projects\Burger-Frontend\burger\src\app\components\Navbar\Navbar.js#default`);var h=r(96557);r(97001);var b=r(71159),g=r(5263);let j={title:"Burger"};function v({children:e}){return(0,n.jsxs)("html",{lang:"en",children:[n.jsx("head",{children:n.jsx("link",{rel:"preload",href:"/"})}),n.jsx("body",{className:`${o().className} flex flex-col min-h-screen`,children:(0,n.jsxs)(c,{children:[n.jsx(h.Ix,{position:"top-center",autoClose:2e3}),(0,n.jsxs)(b.Suspense,{fallback:n.jsx(g.default,{}),children:[n.jsx(m,{}),n.jsx("main",{className:"flex-grow",children:e}),n.jsx(i,{})]})]})})]})}},5023:()=>{}};var t=require("../../webpack-runtime.js");t.C(e);var r=e=>t(t.s=e),n=t.X(0,[948,781],()=>r(21152));module.exports=n})();