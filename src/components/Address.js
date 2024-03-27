import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { render } from '@testing-library/react';
//import { render } from '@testing-library/react';
//import { useNavigate } from 'react-router-dom';

function Address() {
  const [post, setPost] = useState([]);
  const data = [];
  //const navigate = useNavigate();
  useEffect(() => {

    async function fetchData() {
      
      await axios.get('http://localhost:5251/api/AddressToClient')
        .then(response => {
          setPost((response.data).json);
          // data = response.data;
          console.log("res.data", response.data);
          console.log("post", post);
          console.log("data", data);
        })
        .then((response) => response.json())
        .catch(error => (console.log(error)));
    }
    fetchData();
  })

  // }, []);
  // useEffect(() => {
  //   (async () => {
  //     const response = await axios.get('http://localhost:5251/api/AddressToClient');
  //     console.log(response);
  //     const data = response.data;
  //     // data contains all the posts which are successfully logged
  //     console.log(data);

  //     // Here posts is logged as empty array [].........why?
  //     setPost1(data);
  //     console.log("posts are: ", post);
  //   })();
  // }, []);
  // const [post, setPost] = useState(null);
  // useEffect(()=>{
  //   const fetchData = async()=>{
  //     try{
  //       const response = await axios.get('http://localhost:5251/api/AddressToClient');
  //       const json = await response.json;
  //       setPost(json);
  //       console.log("post",post);
  //       console.log("json",json);

  //     }
  //     catch{
        
  //     }
  //   }
  //   fetchData();
  // })


    return (
    <>

    <div>
      Users

      {/* {post.map(address => {
        <div key={address.id}>
          <p>{address.city},{address.nighbord}</p>
        </div>
      })} */}
    </div>
    </>
  )
}
export default Address;