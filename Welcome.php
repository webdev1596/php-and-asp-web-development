<?php
defined('BASEPATH') OR exit('No direct script access allowed');
header('Access-Control-Allow-Origin: *');
class Welcome extends CI_Controller {

	/**
	 * Index Page for this controller.
	 *
	 * Maps to the following URL
	 * 		http://example.com/index.php/welcome
	 *	- or -
	 * 		http://example.com/index.php/welcome/index
	 *	- or -
	 * Since this controller is set as the default controller in
	 * config/routes.php, it's displayed at http://example.com/
	 *
	 * So any other public methods not prefixed with an underscore will
	 * map to /index.php/welcome/<method_name>
	 * @see https://codeigniter.com/user_guide/general/urls.html
	 */
	public function __construct()
        {
                parent::__construct();
                $this->load->model('Learn_model');
                $this->load->helper('url_helper');
				$this->load->helper('url');
				$this->load->helper('form');
				$this->load->library('session');

				
		}
	public function index()
	{
		$this->load->view('sitehome');

	}






	public function about()
	{
		$this->load->view('aboutus');
	}

	public function first()

	{
		$this->load->view('firstpage');
	}


	public function profilepage()
	{

	}



public function signup()
{
	$data=array();
	$data['msg']=$this->Learn_model->getsignup();
	$this->load->view('demo',$data);
}

public function login($msg = NULL)
{
	$data['msg'] = $msg;
	$this->load->view('demo',$data);

}
 public function process(){
 	$data=array();
		if(($this->input->post('login'))=="Login")
		{
			$result = $this->Learn_model->validate();
			// Now we verify the result
			if(!$result){
				$msg = '<font color=red>Invalid username and/or password.</font><br />';
				$this->index($msg);
			}else{
				$data['username']=$this->session->userdata('username');
				$this->load->view("loginpage",$data);
			}    
		}
		else
		{
			redirect("demo");
		}
    }
}
