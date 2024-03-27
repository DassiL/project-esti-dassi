// function A() {
//     const [post, setPost] = navigate("/A");
//     return (
//         <div>
//             Users
//             {post.map(address => {
//                 <div key={address.id}>
//                     <p>{address.city},{address.nighbord}</p>
//                 </div>
//             })}
//         </div>
//     )
// }
// export default A;


function Welcome(props) {
    return <h1>Hello, {props.post}</h1>;
  }