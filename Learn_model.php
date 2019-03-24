<?php
class Learn_model extends CI_Model {
public function __construct()
        {
                parent::__construct();
               	$this->load->library('session');
               	$this->load->database();
        }
				
function getsignup()
{
	$id=rand(1000,999999);
	$username=$this->input->post('username');
	$email=$this->input->post('email');
	$password=md5($this->input->post('password'));
	$age=$this->input->post('age');
	$university=$this->input->post('university');
	$profession=$this->input->post('profession');

	$data = array(
		'id'=>$id,
        'username' =>$username,
        'email' => $email,
        'password' => $password,
        'age'=>$age,
        'university'=>$university,
        'profession'=>$profession
);

$this->db->insert('usersign', $data);
}
 public function validate(){
        // grab user input
        $username = $this->security->xss_clean($this->input->post('useremail'));
        $password = $this->security->xss_clean($this->input->post('userpassword'));
        // Prep the query
		$sql="select * from login where username=? and password=?";
		$query=$this->db->query($sql,array($username,$password));
		if($query->num_rows()>0)
        {
            // If there is a user, then create session data
            $row = $query->row();
			$userid=$row->id;
			$username=$row->username;
			$this->session->set_userdata('userid',$userid);
			$this->session->set_userdata('username',$username);
			$this->session->set_userdata('validated',true);
            if($this->session->has_userdata('validated'))
			return true;
			else
			return false;
        }
		else
		{
        // If the previous process did not validate
        // then return false.
		return false;
       //return false;
		}
    }

}
?>